using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalFSpeed
{
    public partial class FSpeed : Form
    {
        public FSpeed()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Audi audi = new Audi(); 
            audi.Tag = this;
            audi.Show(this);
            Hide();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            BMW bmw = new BMW();
            bmw.Tag = this;
            bmw.Show(this);
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ferrari rarri = new Ferrari();
            rarri.Tag = this; 
            rarri.Show(this);
            Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Lamborghini lambo = new Lamborghini();
            lambo.Tag = this;
            lambo.Show(this);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           RollsRoyce rr = new RollsRoyce();
            rr.Tag = this;
            rr.Show(this);
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
