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
        public frmRegjistrimiPlumbave()
        {
            InitializeComponent();
        }

        private void btnRegjistroArmen_Click(object sender, EventArgs e)
        {
            string kalibri = txtKalibri.Text;
            string sasia = txtSasia.Text;

            RegjistroPlumbatBO user = RegjistroPlumbatBLL.RegjistroKlient(sasia, kalibri);


            MessageBox.Show("Ju keni regjistruar klient", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
