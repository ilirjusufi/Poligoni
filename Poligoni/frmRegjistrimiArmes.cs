﻿using Poligoni.BLL;
using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmRegjistrimiArmes : Form
    {
        public frmRegjistrimiArmes()
        {
            InitializeComponent();
        }

        private void RegjistrimiArmes_Load(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
    
            string EmriArmes = txtEmriArmes.Text;
            int Kalibri = Convert.ToInt32(txtKalibri.Text);
            int MaxPlumba = Convert.ToInt32(txtMaxPlumba.Text);


            ArmaBO user = ArmaBLL.RegjistroArmen(EmriArmes,Kalibri,MaxPlumba);


            MessageBox.Show("Ju keni regjistruar nje arme", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void jTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaxPlumba_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKalibri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
