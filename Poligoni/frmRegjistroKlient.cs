using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligoni.BLL;
using Poligoni.BO;
using Poligoni.DAL;

namespace Poligoni
{
    public partial class frmRegjistroKlient : Form
    {
        public frmRegjistroKlient()

        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            frmRegjistrimiArmes.Show();
            frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
            frmRegjistrimiPlumbave.Show();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poligoniDataSet1.Arma' table. You can move, or remove it, as needed.
          

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emri = txtEmriKlientit.Text;
            string mbiemri = txtMbiemriKlientit.Text;
            Users user = add.shto(emri, mbiemri);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            string emri = txtEmriKlientit.Text;
            string mbiemri = txtMbiemriKlientit.Text;
            Users user = add.shto(emri, mbiemri);
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
