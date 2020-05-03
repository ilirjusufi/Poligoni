using Microsoft.VisualBasic.ApplicationServices;
using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;

namespace Poligoni
{
    public partial class listoklientat : Form
    {
        private List<Users> listoKlientat;
        public listoklientat()
        {
            InitializeComponent();
            listoKlientat = new List<Users>();
            LoadData();
        }
        private void LoadData()
        {
            listoKlientat.Clear();

            listoKlientat = listoKlient.listoLlientat("dfdfd", "j");

            this.bindingSource1.Clear();

            listoKlientat.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });
        }
        private void listoklientat_Load(object sender, EventArgs e)
        {


            listoKlient.listoLlientat("dsffd", "2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search;
            search = textkos.Text;

            listoKlientat = listoKlient.listoLlientat(search, "p");

            this.bindingSource1.Clear();

            listoKlientat.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridiListo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new Users();

                d.Emri = this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value.ToString();

                string qo = d.Emri;

                listoKlient.fshij(qo);

                LoadData();



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegjistroklienta frmRegjistroklienta = new frmRegjistroklienta();
            if (this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new Users();

                d.Emri = this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value.ToString();

                string qo = d.Emri;

                frmRegjistroklienta.editoklientat(qo);



            }

        }
    }
}
