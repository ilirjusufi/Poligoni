using Poligoni.BLL;
using Poligoni.BO;
using usersesion;
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
    public partial class frmLogin : Form
    {
        FrmDashboard FrmDashboard = new FrmDashboard();
        public frmLogin()
        {
           
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Useri = txtUser.Text;
            string Passwordi = txtPass.Text;
            Users user = UserBLL.Login(Useri, Passwordi);
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnKyqu_Click(object sender, EventArgs e)
        {
            
            string Useri = txtUser.Text;
            string Passwordi = txtPass.Text;
            
            if (Useri.Trim() != "" && Passwordi != "")
            {
                Users user = UserBLL.Login(Useri, Passwordi);

                if (user != null)
                {
                    if(user.UserRoleID == 1)
                    {
                        UserSession.CurrentUser = user;
                        this.Hide();
                        FrmDashboard.go(1);

                    }
                  else if(user.UserRoleID == 2)
                    {
                        FrmDashboard.go(2);
                        this.Hide();
                    }
                       
                    

                }
                else
                {
                    MessageBox.Show("Username or password invalid");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnKyqu.DialogResult = DialogResult.OK;
        }
    }
}
