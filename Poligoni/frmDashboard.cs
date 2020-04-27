using System;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Items[0].Visible = false;
            string emri = textBox1.Text;
            string mbiemri = textBox2.Text;
            Users user = add.shto(emri, mbiemri);
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
                frlogin.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
