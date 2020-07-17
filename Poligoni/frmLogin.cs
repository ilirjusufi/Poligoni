﻿using Poligoni.BLL;
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
using Poligoni.DAL;
using System.Management;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Poligoni
{
    public partial class frmLogin : Form
    {
        static string a;
        FrmDashboard FrmDashboard = new FrmDashboard();
        public frmLogin()
        {
            
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq-al");

            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Useri = txtpass2.Text;
            string Passwordi = txtuser1.Text;
            Users user = UserBLL.Login(Useri, Passwordi);
            
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnKyqu_Click(object sender, EventArgs e)
        {
            
      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            
            btnkyquu.DialogResult = DialogResult.OK;
            FrmDashboard.StartPosition = FormStartPosition.CenterParent;
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lidhjainternet.CheckForInternetConnection())
            {
                string Useri = txtpass2.Text;
                string Passwordi = txtuser1.Text;

                if (Useri.Trim() != "" && Passwordi != "")
                {
                    Users user = UserBLL.Login(Useri, Passwordi);

                    if (user != null)
                    {
                        if (user.UserRoleID == 1)
                        {
                            UserSession.CurrentUser = user;
                            this.Hide();

                            UserSession1.CurrentUser = user;




                        }
                        else if (user.UserRoleID == 2)
                        {
                            UserSession1.CurrentUser = user;

                            this.Hide();
                        }

                        else
                        {
                            UserSession1.CurrentUser = user;
                        }



                    }
                    else
                    {
                        
                        MessageBox.Show("Username or password invalid");
                        Application.Exit();

                        
                    }
                }
                

            }
           else
            {
                MessageBox.Show("Konttroloni lidhjen ne internet");
                Application.Exit();
            }
            
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void DropGjuha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropGjuha.SelectedIndex)
            {
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-au");
                 
                    a = "en-au";
                    btnkyquu.Text = "Login";
                    btnanuloo.Text = "Cancle";
                    break;
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq-al");
                    btnkyquu.Text = "Kyqu";
                    btnanuloo.Text = "Anulo";
                    a = "sq-al";
                    break;
            }
           
            gjuha.Gjuha =a;
          
            




        }

    }
}
