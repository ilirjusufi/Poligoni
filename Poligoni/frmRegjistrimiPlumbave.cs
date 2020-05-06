using Poligoni.BLL;
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

namespace Poligoni
{
    public partial class frmRegjistrimiPlumbave : Form
    {
        public int PlumbiID { get; set; }
        public int Sasia { get; set; }

        public int Kalibri { get; set; }
        public frmRegjistrimiPlumbave()
        {
            InitializeComponent();
            btnNdryshoPlumbat.Hide();
            lblNdryshimi.Hide();
            
        }

        private void btnRegjistroArmen_Click(object sender, EventArgs e)
        {
            int kalibri = Convert.ToInt32(txtKalibri.Text);
            int sasia = Convert.ToInt32(txtSasia.Text);

            RegjistroPlumbatBO plumbat = RegjistroPlumbatBLL.RegjistroPlumbat(sasia, kalibri);


            MessageBox.Show("Ju keni ndryshuar te dhenat", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void NdryshoPlumbat(int PlumbiID,int kalibri, int sasia)
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

        private void btnNdryshoPlumbat_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            this.Kalibri = int.Parse(txtKalibri.Text);
            this.Sasia = int.Parse(txtSasia.Text);
            RegjistroPlumbatBO NdryshoPlumbat = RegjistroPlumbatBLL.ndryshoPlumbat(PlumbiID, Kalibri, Sasia);
            
            
            
        }

        private void frmRegjistrimiPlumbave_Load(object sender, EventArgs e)
        {

        }
    }
}
