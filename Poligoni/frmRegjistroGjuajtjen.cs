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
			gjuajtja.kalbri = txtKalibri.Text;
			gjuajtja.distanca = Txtdistanca.Text;
			gjuajtja.maxplumba = txtMaxPlumba.Text;
			gjuajtja.klienti = dropklientat.Text;
			gjuajtja.Arma = droparmet.Text;


			gjuajtja = gjuajtjabll.gjuaje(a);






		}

		private void frmRegjistroGjuajtjen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet2.Userat' table. You can move, or remove it, as needed.
            this.useratTableAdapter1.Fill(this.dB_A62C25_poligoniDataSet2.Userat);
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet1.Userat' table. You can move, or remove it, as needed.
            this.useratTableAdapter.Fill(this.dB_A62C25_poligoniDataSet1.Userat);
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.
            this.armaTableAdapter.Fill(this.dB_A62C25_poligoniDataSet.Arma);
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet.Arma' table. You can move, or remove it, as needed.


        }
    }
}
