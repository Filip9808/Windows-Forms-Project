﻿using System;
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
    public partial class RollsRoyce : Form
    {
        public RollsRoyce()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FSpeed fSpeed = new FSpeed();
            fSpeed.Tag = this;
            fSpeed.Show(this);
            Hide();
        }
    }
}
