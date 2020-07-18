using Poligoni.BLL;
using Poligoni.BO;
using System;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmRegjistroStaff : Form
    {
        public frmRegjistroStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Emri = txtstafemri.Text;
            string Mbiemri = txtstafmbiemri.Text;
            string username = txtstafusername.Text;
            string Password = txtstafpassword.Text;
            string Email = txtstafemail.Text;
            Users user = UserBLL.RegjistroKlient(Emri, Mbiemri, username, Password, Email, 2);


            MessageBox.Show("Ju keni regjistruar staf", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
