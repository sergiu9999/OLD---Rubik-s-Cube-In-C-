using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Rezolva : Form
    {

        bool pressed = false;
        double milisecs = 0;

        public Rezolva()
        {
            InitializeComponent();
            this.Focus();
            this.KeyPress +=new KeyPressEventHandler(Rezolva_KeyPress);
        }


        private void Invata_Click(object sender, EventArgs e)
        {
            this.Hide();

            Statistici stats = new Statistici();
            stats.Closed += (s, args) => this.Show();

            stats.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milisecs += timer1.Interval;
            timePassed.Text = (milisecs / 1000).ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rezolva_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Rezolva_Load(object sender, EventArgs e)
        {
            
        }

        
        private void statisticiBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Rezolva_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (pressed)
                {
                    timer1.Stop();
                    pressed = false;

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

                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Timp(ID_utilizator, Timp, Data) VALUES (@idUser, @score, @date)", con);

                        cmd.Parameters.AddWithValue("@idUser", Login.userId);
                        cmd.Parameters.AddWithValue("@score", milisecs / 1000);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                }

                else
                {
                    timer1.Start();
                    pressed = true;

                    timePassed.Text = "0";
                    milisecs = 0;
                }
            }
        }
    }
}
