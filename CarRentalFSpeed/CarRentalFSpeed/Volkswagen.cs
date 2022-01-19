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
    public partial class Volkswagen : Form
    {
        public Volkswagen()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FSpeed fSpeed = new FSpeed();
            fSpeed.Tag = this;
            fSpeed.Show(this);
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Volkswagen vw = new Volkswagen();
            vw.Tag = this;
            vw.Show(this);
            Hide();
        }
    }
}
