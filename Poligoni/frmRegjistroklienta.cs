using Poligoni.BLL;
using Poligoni.BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmRegjistroklienta : Form
    {
        public int userID { get; set; }
        public string Emri { get; set; }

        public string Mbiemri { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public frmRegjistroklienta()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(gjuha.Gjuha);
            InitializeComponent();
            btnEdito.Hide();
            
            if(gjuha.Gjuha == "sq-al")
            label6.Text = "Regjistro Klient";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Emri = btnEmri.Text;
            string Mbiemri = btnMbiemri.Text;
            string username = Btnusername.Text;
            string Password = btnPassword.Text;
            string Email = btnEmail.Text;
            Users user = UserBLL.RegjistroKlient(Emri, Mbiemri, username, Password, Email, 3);


            MessageBox.Show("Ju keni regjistruar klient", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmri_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnEmri_TextChanged_1(object sender, EventArgs e)
        {

        }


        public void editoklientat(int userID, string emri, string mbiemri, string username, string email)
        {

            btnShto.Hide();
            Btnusername.Enabled = false;
            label6.Text = "Edito Klient";
            btnEdito.Show();
            string edito = emri;
            btnEmri.Text = emri;
            btnMbiemri.Text = mbiemri;
            Btnusername.Text = username;
            btnEmail.Text = email;
            this.Show();
            this.Emri = emri;
            this.userID = userID;
            this.Mbiemri = mbiemri;
            this.Username = username;
            this.Email = email;


        }
        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void frmRegjistroklienta_Load(object sender, EventArgs e)
        {
            
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            this.Emri = btnEmri.Text;
            this.Mbiemri = btnMbiemri.Text;
            this.Username = Btnusername.Text;
            this.Email = btnEmail.Text;
            Users EditoKlient = UserBLL.editoKlienta(userID, Emri, Mbiemri, Username, Email);

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (gjuha.Gjuha == "en-au")
                Help.ShowHelp(this, "./poligonihelpguideen.chm", HelpNavigator.Topic, "20.htm");
            else
                Help.ShowHelp(this, "./poligonihelpguide.chm", HelpNavigator.Topic, "20.htm");
        }
    }
}
