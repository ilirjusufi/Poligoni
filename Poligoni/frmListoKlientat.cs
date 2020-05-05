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
using System.Security.Cryptography.X509Certificates;

namespace Poligoni
{
    public partial class frmListoKlientat : Form
    {
        private List<Users> listoKlientat;
        public frmListoKlientat()
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
            if (e.ColumnIndex == gridiListo.Columns["Fshij"].Index && e.RowIndex >= 0){ 
            if (this.gridiListo[1, gridiListo.CurrentCell.RowIndex].Value.ToString() != null)
            {
                var d = new Users();

                d.ID = Convert.ToInt32(this.gridiListo[0, gridiListo.CurrentCell.RowIndex].Value);

                int qo = d.ID;

                listoKlient.fshij(qo);

                LoadData();

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

                LoadData();

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
                string mbiemri =  this.gridiListo[2, gridiListo.CurrentCell.RowIndex].Value.ToString();
                string username = this.gridiListo[3, gridiListo.CurrentCell.RowIndex].Value.ToString();
                string email = this.gridiListo[4, gridiListo.CurrentCell.RowIndex].Value.ToString();
                frmRegjistroklienta.editoklientat(userID, emri,mbiemri,username,email);

            }

        }

        private void btnkerko_Click(object sender, EventArgs e)
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

        private void textkos_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
