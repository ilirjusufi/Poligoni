﻿using Poligoni.BO;
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
            btneditogjujtjen.Hide();

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
            FrmDashboard frm = new FrmDashboard();

            this.klienti = dropklientat.Text;
            this.Arma = droparmet.Text;
            this.PiketEshenuara = Convert.ToInt32(txtKalibri.Text);
            this.distanca = Txtdistanca.Text;
            this.plumbashfryzuar = txtMaxPlumba.Text;

            gjuajtja ndryshoHjuajte = gjuajtjabll.ndryshogjuajte(klienti, Arma, distanca, plumbashfryzuar, PiketEshenuara);


            MessageBox.Show("Editimi u krye");
        }
        public void Editogjuajten(string klienti, string Arma, string distanca, string plumbashfryzuar, int PiketEshenuara)
        {

            btnRegjistroGjuajtjen.Hide();
            label2.Text = "Edito Gjuajtjen";
            btneditogjujtjen.Show();
            dropklientat.Text = klienti;
            droparmet.Text = Arma;
            txtKalibri.Text = PiketEshenuara.ToString();
            Txtdistanca.Text = distanca;
            txtMaxPlumba.Text = plumbashfryzuar;
            this.klienti = klienti;
            this.Arma = Arma;
            this.distanca = distanca;
            this.plumbashfryzuar = plumbashfryzuar;
            this.PiketEshenuara = PiketEshenuara;

            this.Show();
        }
        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
