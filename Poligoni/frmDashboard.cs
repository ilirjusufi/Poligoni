using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligoni.BLL;
using Poligoni.BO;

namespace Poligoni
{
    
    public partial class FrmDashboard : Form
    {
        static int go1;
        public void go(int a)
        {

             go1 = a;
        }


        public FrmDashboard()
        {
         
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Items[0].Visible = false;


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
                frlogin.Hide();
              
                if(go1 == 2)
                {
                    menuStrip1.Items[0].Visible = false;
                    menuStrip1.Items[3].Visible = false;
                }

            }
            else
            {
                this.Close();
            }
            
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {
         
        }

        public void administrimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
