using Poligoni.BLL;
using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmRegjistroklienta : Form
    {
        public frmRegjistroklienta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Emri = btnEmri.Text;
            string Mbiemri = btnMbiemri.Text;
            string username = Btnusername.Text;
            string Password = btnPassword.Text;
            string Email = btnEmail.Text;
            Users user = UserBLL.RegjistroKlient(Emri, Mbiemri, username, Password, Email);


            MessageBox.Show("Ju keni regjistruar klient", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
