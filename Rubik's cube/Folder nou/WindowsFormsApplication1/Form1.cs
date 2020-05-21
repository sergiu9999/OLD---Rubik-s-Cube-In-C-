using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Invata_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Closed += (s, args) => this.Show();

            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f2 = new Form8();
            f2.Closed += (s, args) => this.Show();

            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezolva rezolva = new Rezolva();
            rezolva.Closed += (s, args) => this.Show();

            rezolva.Show();
        }
    }
}
