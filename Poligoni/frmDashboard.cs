using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Poligoni
{


    public partial class FrmDashboard : Form
    {
        string c;
        private dashboardStatistikatBO merre;

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




#pragma warning disable CS0164 // This label has not been referenced
        a:
#pragma warning restore CS0164 // This label has not been referenced

            timer1.Start();

            this.StartPosition = FormStartPosition.CenterParent;

            frmLogin frlogin = new frmLogin();
            if (frlogin.ShowDialog() == DialogResult.OK)
            {

                if (gjuha.Gjuha == "en-au")
                {
                    label2.Text = "Dahboard";
                    label18.Text = "Date and Time :";
                    label1.Text = "Hello";
                    label6.Text = "Registered clients";
                    label11.Text = "Total shots";
                    label12.Text = "Total weapons";
                    label13.Text = "Total bullets";
                    label14.Text = "Registered clients in this month";
                    label15.Text = "Shots in this month";
                    label4.Text = "Clients";
                    label17.Text = "Shots";
                    btnregjistoklienta.Text = "Client register";
                    btnregjistroarm.Text = "Register weapons";
                    btnregjistroplumba.Text = "Bullet regjister";
                    btnRegjistroGjuajtje.Text = "Register shots";
                    label2.Location = new Point(60, 8);
                    lblemri.Location = new Point(297, 36);
                    menuStrip1.Items[0].Text = "Administring";
                    menuStrip1.Items[1].Text = "Clientes".ToString();
                    menuStrip1.Items[2].Text = "Weapons".ToString();
                    menuStrip1.Items[3].Text = "Bullets".ToString();
                    menuStrip1.Items[4].Text = "Shoots".ToString();
                    menuStrip1.Items[5].Text = "Help".ToString();
                    regjistroStafToolStripMenuItem.Text = "Register Staf";
                    ndyshoStafToolStripMenuItem.Text = "List of staf";
                    regjistroKlientToolStripMenuItem.Text = "Register Client";
                    listoKlientToolStripMenuItem1.Text = "List of clients";
                    regjistroGjuajtjenToolStripMenuItem.Text = "New Shoot";
                    listoTeGjithaGjuajtjetToolStripMenuItem.Text = "Manage shoots";
                    guna2Button1.Text = "Logout";
                    perAplikacionToolStripMenuItem.Text = "About";
                    manualiIPerdorimitToolStripMenuItem.Text = "Use manual";


                }


                loadData();
                int slep = 2;
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(slep);
                    guna2CircleProgressBar2.Value = i;
                    guna2CircleProgressBar2.Update();


                }
                guna2CircleProgressBar2.Value = 2;
                guna2CircleProgressBar2.Update();




                lblemrimbiemri.Text = UserSession1.CurrentUser.Username.ToString();
                frlogin.Hide();
                lblemri.Text = UserSession1.CurrentUser.Username.ToString();

                if (UserSession1.CurrentUser.UserRoleID == 2)
                {
                    menuStrip1.Items[0].Visible = false;

                    //tesrde
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

        public void loadData()
        {


            merre = dashboardStatistikatDAL.MerrStatistika();

            lblklientaregjistrum.Text = merre.klientateRegjistrua.ToString();
            lblplumbastok.Text = merre.plumbaStok.ToString();
            lblgjuajtjet.Text = merre.gjuajtjaTotale.ToString();
            lblaremtregjistruar.Text = merre.armeRegjisstruar.ToString();
            lblklientamuaj.Text = merre.Klientatmuaj.ToString();
            lblgjuajtjemuaj.Text = merre.Gjuajtjamuaj.ToString();
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
        public void Gjuha(string a)
        {
            this.c = a;
            InitializeComponent();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbldata.Text = dateTime.ToString();
            lbldata.Update();

        }

        private void listoKlientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListoKlientat frmListoKlientat = new frmListoKlientat();
            frmListoKlientat.LoadData(3);
            if (frmListoKlientat.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void fshijKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listoTeGjithePlumbatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListoPlumbat frmListoArmet = new frmListoPlumbat();

            if (frmListoArmet.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void regjistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistrimiArmes frmRegjistrimiArmes = new frmRegjistrimiArmes();
            if (frmRegjistrimiArmes.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void listoTeGjithaArmetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regjistroPlumbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
            if (frmRegjistrimiPlumbave.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void menaxhoPlumbatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListoPlumbat frmListoArmet = new frmListoPlumbat();

            if (frmListoArmet.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menaxhoArmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmenagjoArmet frmmenagjoArmet = new frmmenagjoArmet();
            if (frmmenagjoArmet.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void ndyshoStafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListoKlientat frmListoKlientat = new frmListoKlientat();
            frmListoKlientat.LoadData(2);
            if (frmListoKlientat.ShowDialog() == DialogResult.Abort)
            {


            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Application.Restart();
        }

        private void listoTeGjithaGjuajtjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenagjogjuajtjen femMenagjogjuajtjen = new frmMenagjogjuajtjen();
            if (femMenagjogjuajtjen.ShowDialog() == DialogResult.Abort)
            {

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void GetHelpProvider(Form frm, string topic)
        {


            Help.ShowHelp(frm, "NewPr11oject11.chm", HelpNavigator.Topic, topic);


        }
     
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (gjuha.Gjuha == "en-au")
                Help.ShowHelp(this, "./poligonihelpguideen.chm", HelpNavigator.Topic, "19.htm");
            else
                Help.ShowHelp(this, "./poligonihelpguide.chm", HelpNavigator.Topic, "19.htm");
        }

        private void perAplikacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poligoni ver 1.3", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void manualiIPerdorimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gjuha.Gjuha == "en-au")
                Help.ShowHelp(this, "./poligonihelpguideen.chm", HelpNavigator.Topic, "menagjimi.htm");
            else
                Help.ShowHelp(this, "./poligonihelpguide.chm", HelpNavigator.Topic, "menagjimi.htm");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
