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
    public partial class frmMenaxhimiStokut : Form
    {
        public frmMenaxhimiStokut()
        {
            InitializeComponent();
        }

        private void frmMenaxhimiStokut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A57CDC_poligoniDataSet.Userat' table. You can move, or remove it, as needed.
            this.useratTableAdapter.Fill(this.dB_A57CDC_poligoniDataSet.Userat);

        }
    }
}
