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
using Poligoni.BLL;

namespace Poligoni
{
	public partial class frmRegjistroGjuajtjen : Form
	{
		gjuajtja gjuajtja = new gjuajtja();
        public int PiketEshenuara { get; set; }
        public string distanca { get; set; }
        public string plumbashfryzuar { get; set; }
        public string klienti { get; set; }
        public string Arma { get; set; }
        public frmRegjistroGjuajtjen()

		{
			
			InitializeComponent();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnRegjistroGjuajtjen_Click(object sender, EventArgs e)
		{
			string a = "a";
			string kalbri = txtKalibri.Text;
			string distanca = Txtdistanca.Text;
			string maxplumba = txtMaxPlumba.Text;
			string klienti = dropklientat.Text;
			string Arma = droparmet.Text;


			gjuajtja = gjuajtjabll.gjuaje(kalbri, distanca, maxplumba, klienti, Arma);






		}

		private void frmRegjistroGjuajtjen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet2.Userat' table. You can move, or remove it, as needed.
            this.useratTableAdapter1.Fill(this.dB_A62C25_poligoniDataSet2.Userat);
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet1.Userat' table. You can move, or remove it, as needed.
     
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.
            this.armaTableAdapter.Fill(this.dB_A62C25_poligoniDataSet.Arma);
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.


        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {

        }
        public void Editogjuajten(string kalbri, string distanca, string maxplumba, string klienti, string Arma)
        {

            label1.Hide();
            btnRegjistroPlumbat.Hide();
            lblNdryshimi.Show();
            btnNdryshoPlumbat.Show();
            txtKalibri.Text = Convert.ToString(kalibri);
            txtSasia.Text = Convert.ToString(sasia);
            this.PlumbiID = PlumbiID;
            this.Kalibri = kalibri;
            this.Sasia = sasia;

            this.Show();
        }
        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
