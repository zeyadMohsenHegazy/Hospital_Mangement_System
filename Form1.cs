﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    
    public partial class LoginForm : Form
    {
        Main mainform;
        HospitalEntities hospitalEntities;

        public LoginForm()
        {
            InitializeComponent();
            hospitalEntities = new HospitalEntities();
            mainform = new Main();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            var user = hospitalEntities.Users;
            var Query = (from z in hospitalEntities.Users
                         where z.UserName == UserNameTxt.Text && z.Password == PasswordTxt.Text
                         select z).Count();
            if (Query == 1)
            {

                #region send user data through the app
                mainform.UserNameL = UserNameTxt.Text;
                mainform.Role = PasswordTxt.Text;
                #endregion

                mainform.ShowDialog();
                UserNameTxt.Text = String.Empty;
                PasswordTxt.Text = String.Empty;

            }
            else
            {
                LogcheckTxt.Text = "The user name or password is wrong";
                LogcheckTxt.Visible = true;
                UserNameTxt.Text = String.Empty;
                PasswordTxt.Text = String.Empty;
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if(UserNameTxt.Text.Length >= 1)
            {
                LogcheckTxt.Visible = false;
            }
        }

        private void ShowPasswordTxt_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordTxt.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
            else
                PasswordTxt.UseSystemPasswordChar = true;

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if(!ShowPasswordTxt.Checked)
                PasswordTxt.UseSystemPasswordChar = true;
        }
    }
}
