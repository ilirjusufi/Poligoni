using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poligoni.BLL;
using Poligoni.BO;


namespace Poligoni
{

    public partial class FrmDashboard : Form
    {


        public FrmDashboard()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listoTeGjitheKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            


            lbldata.Text = DateTime.Now.ToString();
            lbldata.Update();




            this.StartPosition = FormStartPosition.CenterParent;

            frmLogin frlogin = new frmLogin();
            if (frlogin.ShowDialog() == DialogResult.OK)
            {
               
                int slep = 20;
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(slep);
                    guna2CircleProgressBar2.Value = i;
                    guna2CircleProgressBar2.Update();
                    lblfinancat.Text = i.ToString() + " €";
                    lblfinancat.Update();
                    if (i == 80) slep = 100;
                    if (i == 90) slep = 200;


                }


                lblemrimbiemri.Text = UserSession1.CurrentUser.Username.ToString();
                frlogin.Hide();
                lblemri.Text = UserSession1.CurrentUser.Username.ToString();

                if (UserSession1.CurrentUser.UserRoleID == 2)
                {
                    menuStrip1.Items[0].Visible = false;
                    menuStrip1.Items[3].Visible = false;
                }
                else
                if (UserSession1.CurrentUser.UserRoleID == 3)
                {
                    menuStrip1.Hide();
                }

            }
            else
            {
                this.Close();
            }
            // ndryshimi i userave
        }

        private void FrmDashboard_Load_1(object sender, EventArgs e)
        {

        }

        public void administrimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ndryshoStafToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void regjistroStafToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmRegjistroklienta frmRegjistroKlient = new frmRegjistroklienta();
            frmRegjistroKlient.Show();
        }

        private void jGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            frmRegjistroklienta frmRegjistroklienta = new frmRegjistroklienta();
            frmRegjistroklienta.Show();
        }

        private void regjistroArmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            frmRegjistrimiArmes.Show();
        }

        private void regjistroPlumbatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
            frmRegjistrimiPlumbave.Show();
        }

        private void dfgdgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dfgdgToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regjistroKlientToolStripMenuItem_Click_4(object sender, EventArgs e)
        {
            frmRegjistroklienta klientatform = new frmRegjistroklienta();
            if (klientatform.ShowDialog() == DialogResult.Abort)
            {

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnregjistoklienta_Click(object sender, EventArgs e)
        {
            frmRegjistroklienta klientatform = new frmRegjistroklienta();
            if (klientatform.ShowDialog() == DialogResult.Abort)
            {

            }

        }

        private void lblfinancat_Click(object sender, EventArgs e)
        {

        }

        private void btnregjistroarm_Click(object sender, EventArgs e)
        {
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            if (frmRegjistrimiArmes.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void raportetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regjistroGjuajtjenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistroGjuajtjen frmRegjistroGjuajtjen = new frmRegjistroGjuajtjen();
            if (frmRegjistroGjuajtjen.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void btnRegjistroGjuajtje_Click(object sender, EventArgs e)
        {
            frmRegjistroGjuajtjen frmRegjistroGjuajtjen = new frmRegjistroGjuajtjen();
            if (frmRegjistroGjuajtjen.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void regjistroArmetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            if (frmRegjistrimiArmes.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void regjistroPlumbatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
            if (frmRegjistrimiPlumbave.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void btnregjistroplumba_Click(object sender, EventArgs e)
        {
            frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
            if (frmRegjistrimiPlumbave.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void regjistroStafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistroStaff frmRegjistroStaff = new frmRegjistroStaff();
            if (frmRegjistroStaff.ShowDialog() == DialogResult.Abort)
            {
                
            }
        }
    }
}
