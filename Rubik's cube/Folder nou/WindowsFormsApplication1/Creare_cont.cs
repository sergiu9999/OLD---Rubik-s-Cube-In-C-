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
    public partial class Creare_cont : Form
    {
        public Creare_cont()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
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

                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM Conturi WHERE Utilizator = @user", con);

                        cmd.Parameters.AddWithValue("@user", userTxt.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Utilizatorul exista deja in baza de date!");
                            userTxt.Text = "";
                            pwdTxt.Text = "";
                            userTxt.Focus();
                        }

                        else
                        {
                            reader.Close();
                            cmd.Parameters.Clear();
                            cmd.CommandText = @"INSERT INTO Conturi(Utilizator, Parola) VALUES(@user, @pwd)";

                            cmd.Parameters.AddWithValue("@user", userTxt.Text);
                            cmd.Parameters.AddWithValue("@pwd", pwdTxt.Text);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Utilizatorul a fost adaugat cu succes in baza de date!");

                                this.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("S-a produs o eroare la server:\n" + ex.ToString());
                                userTxt.Text = "";
                                pwdTxt.Text = "";
                            }
                        }
                    }
                }

            }

        }
    }
}
