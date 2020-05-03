using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligoni.DAL;
using Poligoni.BO;


namespace Poligoni
{
    public partial class frmListoKlientat : Form
    {
        private List<Users> lstD;
        public frmListoKlientat()
        {
            InitializeComponent();

            lstD = new List<Users>();
            LoadData();

            InitializeComponent();

           
        }
        private void LoadData()
        {
            lstD.Clear();

            lstD = listoKlient.listoLlientat("dfdfd","j") ;

            this.bindingSource1.Clear();

            lstD.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });



        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmListoKlientat_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listoKlient.listoLlientat("kerko","j");
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            

            var kerko = txtkerko.Text;



            lstD = listoKlient.listoLlientat(kerko, "p");

            this.bindingSource1.Clear();

            lstD.ForEach(delegate (Users d)
            {
                this.bindingSource1.Add(d);

            });
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
