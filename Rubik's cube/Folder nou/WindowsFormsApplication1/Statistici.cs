using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Statistici : Form
    {

        Series series;

        List<DateTime> date;
        List<int> timp;
        
        public Statistici()
        {
            InitializeComponent();
            series = new Series();
        }

        private void Statistici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubiksDataSet.Timp' table. You can move, or remove it, as needed.
            this.timpTableAdapter.Fill(this.rubiksDataSet.Timp);
            series.Palette = ChartColorPalette.None;

            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string[] paths = location.Split('\\');

            string path = "";

            for (int index = 0; index < paths.Length - 3; index++)
            {
                path += paths[index] + '\\';
            }

            path += "Rubiks.mdf";

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + path + ";Integrated Security=True;User Instance=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Timp WHERE ID_utilizator = @userID", con);

                cmd.Parameters.AddWithValue("@userID", Login.userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    series.Points.AddXY(reader["Data"].ToString(), reader["Timp"].ToString());

                    //timp.Add(int.Parse(reader["Timp"].ToString()));
                    //date.Add(DateTime.Parse(reader["Date"].ToString()));
                }

                series.Name = "Gained time";

                chart1.Series.Add(series);
                
            }
        }

        private void statisticiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
