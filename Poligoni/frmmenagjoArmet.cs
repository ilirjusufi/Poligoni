using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class frmmenagjoArmet : Form
    {
        private List<ArmaBO> Edito;
        public frmmenagjoArmet()
        {
            InitializeComponent();
            Edito = new List<ArmaBO>();
            LoadData();
        }

        private void LoadData()
        {
            Edito.Clear();

            Edito = ArmaDAL.ListoArmet("sadfsdf", "sadff");

            this.bindingSource1.Clear();

            Edito.ForEach(delegate (ArmaBO d)
            {
                this.bindingSource1.Add(d);

            });
        }
        private void frmmenagjoArmet_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Edito.Clear();
            string serarch = txtSearch.Text;
            Edito = ArmaDAL.ListoArmet(serarch, "p");

            this.bindingSource1.Clear();

            Edito.ForEach(delegate (ArmaBO d)
            {
                this.bindingSource1.Add(d);

            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();

            if (this.dsatagridArmet[0, dsatagridArmet.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new ArmaBO();
                int ArmaID = Convert.ToInt32(this.dsatagridArmet[0, dsatagridArmet.CurrentCell.RowIndex].Value);
                string emriArmes = this.dsatagridArmet[1, dsatagridArmet.CurrentCell.RowIndex].Value.ToString();
                string Kalibri = this.dsatagridArmet[2, dsatagridArmet.CurrentCell.RowIndex].Value.ToString();
                int maxPlumba = Convert.ToInt32(this.dsatagridArmet[3, dsatagridArmet.CurrentCell.RowIndex].Value);
                frmRegjistrimiArmes.editoArmen(ArmaID, emriArmes, Kalibri, maxPlumba);
            }

        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            if (this.dsatagridArmet[0, dsatagridArmet.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new ArmaBO();

                d.ArmaID = Convert.ToInt32(this.dsatagridArmet[0, dsatagridArmet.CurrentCell.RowIndex].Value);

                int qo = d.ArmaID;

                ArmaDAL.fshij(qo);

                LoadData();

            }
        }

        private void dsatagridArmet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
