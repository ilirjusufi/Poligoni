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
        public string Emri { get; set; }
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
            Users user = UserBLL.RegjistroKlient(Emri, Mbiemri, username, Password, Email,3);


            MessageBox.Show("Ju keni regjistruar klient", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmri_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnEmri_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void editoklientat(string emri)
        {
            string edito = emri;
            string Emri = "", Mbiemri = "", username = "", Password = "", Email = "";
            Users editoklient = UserBLL.editoKlienta(edito,Emri, Mbiemri, username, Email );
            btnEmri.Text = editoklient.Emri;
            btnMbiemri.Text = editoklient.Mbiemri;
            Btnusername.Text = editoklient.Username;
            btnEmail.Text = editoklient.Email;
            this.Show();
            

        }
        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        
        }
    }
}
