﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligoni.BLL;
using Poligoni.BO;


namespace Poligoni
{
    
    public partial class FrmDashboard : Form
    {
       

        public FrmDashboard()
        {
         
            
            InitializeComponent();
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            frmRegjistrimiArmes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void listoTeGjitheKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            frmLogin frlogin = new frmLogin();
            if (frlogin.ShowDialog() == DialogResult.OK)
            {
                label1.Text = UserSession1.CurrentUser.Username.ToString();
                frlogin.Hide();

                if (UserSession1.CurrentUser.Username == "staf")
                {
                    menuStrip1.Items[0].Visible = false;
                    menuStrip1.Items[3].Visible = false;
                }
                else
                    return;

            }
            else
            {
                this.Close();
            }
            // ndryshimi i userave
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {
            
        }

        public void administrimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ndryshoStafToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void regjistroStafToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRegjistroklienta frmRegjistroKlient = new frmRegjistroklienta();
            frmRegjistroKlient.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
