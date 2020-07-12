using Poligoni.BLL;
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
        public int ArmaID { get; set; }
        public string EmriArmes { get; set; }
     
        public string Kalibiri { get; set; }
        public int MaxPlumba
        {
            get; set;
        }
        public frmRegjistrimiArmes()
        {
            InitializeComponent();
            btnEdito.Hide();

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

        public void editoArmen(int ArmaID,string EmriArmes, string Kalibiri, int MaxPlumba)
        {

            
            btnEdito.Show();
            this.ArmaID = ArmaID;
            this.EmriArmes = EmriArmes;
            this.Kalibiri = Kalibiri;
            this.MaxPlumba = MaxPlumba;
            txtEmriArmes.Text = EmriArmes;
            txtKalibri.Text = Kalibiri;
            txtMaxPlumba.Text = MaxPlumba.ToString();
            btnRegjistroArmen.Hide();
            this.Show();




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

        private void btnEdito_Click(object sender, EventArgs e)
        {
            this.EmriArmes = txtEmriArmes.Text;
            this.Kalibiri = txtKalibri.Text;
            this.MaxPlumba = int.Parse(txtMaxPlumba.Text);
            ArmaBO ndryshoArma = ArmaBLL.ndryshoArma(this.ArmaID,EmriArmes, Kalibiri, MaxPlumba);

           
        }
    }
}
