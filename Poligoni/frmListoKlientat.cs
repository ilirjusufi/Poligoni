﻿using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Poligoni

{

    public partial class frmListoKlientat : Form
    {
        public int rolet { get; set; }
        private List<Users> listoKlientat;
        public frmListoKlientat()
        {

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(gjuha.Gjuha);
            InitializeComponent();
            listoKlientat = new List<Users>();


        }


        public void LoadData(int roli)
        {
            listoKlientat.Clear();
            listoKlientat = listoKlient.listoLlientat(roli, "dfdfd", "j");
            this.bindingSource1.Clear();
            this.rolet = roli;
            listoKlientat.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });
        }
        private void listoklientat_Load(object sender, EventArgs e)
        {
            if (rolet == 2)
            {
                label1.Text = "Listo,fshij,kerko staf";
            }

            listoKlient.listoLlientat(rolet, "dsffd", "2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search;
            search = textkos.Text;

            listoKlientat = listoKlient.listoLlientat(rolet, search, "p");

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
            if (e.ColumnIndex == gridiListo.Columns["Edito"].Index && e.RowIndex >= 0)
            {
                frmRegjistroklienta frmRegjistroklienta = new frmRegjistroklienta();
                if (this.gridiListo[5, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
                {

                    var d = new Users();
                    int userID = Convert.ToInt32(this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value);
                    string emri = this.gridiListo[1, gridiListo.CurrentCell.RowIndex].Value.ToString();
                    string mbiemri = this.gridiListo[2, gridiListo.CurrentCell.RowIndex].Value.ToString();
                    string username = this.gridiListo[3, gridiListo.CurrentCell.RowIndex].Value.ToString();
                    string email = this.gridiListo[4, gridiListo.CurrentCell.RowIndex].Value.ToString();
                    frmRegjistroklienta.editoklientat(userID, emri, mbiemri, username, email);



                }
            }
            else
            if (e.ColumnIndex == gridiListo.Columns["Fshij"].Index && e.RowIndex >= 0)
            {
                if (this.gridiListo[1, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
                {
                    var d = new Users();

                    d.ID = Convert.ToInt32(this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value);

                    int qo = d.ID;

                    listoKlient.fshij(qo);

                    LoadData(rolet);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (this.gridiListo[1, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new Users();

                d.ID = Convert.ToInt32(this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value);

                int qo = d.ID;

                listoKlient.fshij(qo);

                LoadData(3);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegjistroklienta frmRegjistroklienta = new frmRegjistroklienta();
            if (this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new Users();
                int userID = Convert.ToInt32(this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value);
                string emri = this.gridiListo[1, gridiListo.CurrentCell.RowIndex].Value.ToString();
                string mbiemri = this.gridiListo[2, gridiListo.CurrentCell.RowIndex].Value.ToString();
                string username = this.gridiListo[3, gridiListo.CurrentCell.RowIndex].Value.ToString();
                string email = this.gridiListo[4, gridiListo.CurrentCell.RowIndex].Value.ToString();
                frmRegjistroklienta.editoklientat(userID, emri, mbiemri, username, email);

            }

        }

        private void btnkerko_Click(object sender, EventArgs e)
        {
            string search;
            search = textkos.Text;

            listoKlientat = listoKlient.listoLlientat(rolet, search, "p");

            this.bindingSource1.Clear();

            listoKlientat.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });
        }

        private void textkos_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

            if (gjuha.Gjuha == "en-au")
                Help.ShowHelp(this, "./poligonihelpguideen.chm", HelpNavigator.Topic, "27.htm");
            else
                Help.ShowHelp(this, "./poligonihelpguide.chm", HelpNavigator.Topic, "27.htm");
        }
    }
}
