using Poligoni.BLL;
using Poligoni.BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmRegjistroStaff : Form
    {
        public frmRegjistroStaff()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(gjuha.Gjuha);
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           

            if (gjuha.Gjuha == "en-au")
                Help.ShowHelp(this, "./poligonihelpguideen.chm", HelpNavigator.Topic, "25.htm");
            else
                Help.ShowHelp(this, "./poligonihelpguide.chm", HelpNavigator.Topic, "25.htm");
        }

        private void frmRegjistroStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
