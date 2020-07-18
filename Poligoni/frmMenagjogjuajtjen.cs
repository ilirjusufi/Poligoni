using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmMenagjogjuajtjen : Form
    {
        private List<gjuajtja> listoGjuajtjen;
        public frmMenagjogjuajtjen()
        {

            InitializeComponent();
            listoGjuajtjen = new List<gjuajtja>();
            LoadData();
        }

        private void LoadData()
        {


            listoGjuajtjen = gjuajtjalistodal.listoLlientat("k", "p");



            listoGjuajtjen.ForEach(delegate (gjuajtja d)
            {
                this.bindingSource1.Add(d);

            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkerko_Click(object sender, EventArgs e)
        {

        }

        private void frmMenagjogjuajtjen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A62C25_poligoniDataSet4.Gjujtja' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Gridlistogjuajtien[0, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var klient = new gjuajtja();

                klient.klienti = this.Gridlistogjuajtien[0, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString();

                string qo = klient.klienti;

                gjuajtjalistodal.fshij(qo);

                this.bindingSource1.Clear();

                LoadData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegjistroGjuajtjen frmRegjistroGjuajtjen = new frmRegjistroGjuajtjen();

            if (this.Gridlistogjuajtien[0, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new RegjistroPlumbatBO();
                string klienti = this.Gridlistogjuajtien[0, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString();
                string Arma = this.Gridlistogjuajtien[1, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString();
                string distanca = this.Gridlistogjuajtien[2, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString();
                string plumbashfryzuar = this.Gridlistogjuajtien[3, Gridlistogjuajtien.CurrentCell.RowIndex].Value.ToString();
                int PiketEshenuara = Convert.ToInt32(this.Gridlistogjuajtien[4, Gridlistogjuajtien.CurrentCell.RowIndex].Value);
                frmRegjistroGjuajtjen.Editogjuajten(klienti, Arma, distanca, plumbashfryzuar, PiketEshenuara);
            }
        }
    }
}
