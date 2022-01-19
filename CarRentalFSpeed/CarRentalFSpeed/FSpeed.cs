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
            Audi fm = new Audi(); 
            fm.Tag = this;
            fm.Show(this);
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
            MessageBox.Show("Redirecting to facebook.com/fspeed ");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "The request has been sent! :)";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            BMW fm = new BMW();
            fm.Tag = this;
            fm.Show(this);
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ferrari fm = new Ferrari();
            fm.Tag = this; 
            fm.Show(this);
            Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Lamborghini fm = new Lamborghini();
            fm.Tag = this;
            fm.Show(this);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           RollsRoyce fm = new RollsRoyce();
            fm.Tag = this;
            fm.Show(this);
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Thank you, See our offer");
            }
            else
            {
                MessageBox.Show("Lack of access! " + "Accept terms and conditions!");

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

             Volkswagen fm = new Volkswagen();
             fm.Tag = this;
             fm.Show(this);
             Hide();

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to twitter.com/fspeed ");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to instagram.com/fspeed ");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone number: 666 999 000     E-mail: contact@fspeed.com ");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            FSpeed settings = new FSpeed();
            this.Close();
            settings.Close();

        }
    }
}
