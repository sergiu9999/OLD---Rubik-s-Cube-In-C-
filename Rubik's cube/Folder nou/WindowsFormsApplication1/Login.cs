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
    public partial class Login : Form
    {

        public static string userName = "";
        public static int userId = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Creare_cont contnou = new Creare_cont();
            contnou.Closed += (s, args) => this.Show();

            contnou.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "")
                MessageBox.Show("Completati toate campurile!");
            else
            {
                if (pwdTxt.Text == "")
                    MessageBox.Show("Completati toate campurile!");
                else
                {
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

                        SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 * FROM Conturi WHERE Utilizator = @user AND Parola = @pwd", con);

                        cmd.Parameters.AddWithValue("@user", userTxt.Text);
                        cmd.Parameters.AddWithValue("@pwd", pwdTxt.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            userName = reader["Utilizator"].ToString();
                            userId = int.Parse(reader["ID"].ToString());

                            userTxt.Text = "";
                            pwdTxt.Text = "";
                            userTxt.Focus();

                            this.Hide();
                            Form1 f1 = new Form1();
                            f1.Closed += (s, args) => this.Show();

                            f1.Show();
                        }

                        else
                        {
                            MessageBox.Show("Date incorecte!");

                            userTxt.Text = "";
                            pwdTxt.Text = "";
                            userTxt.Focus();
                        }
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
