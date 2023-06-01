using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HospitalEntities hospitalEntities = new HospitalEntities();
            var user = hospitalEntities.Users;
            var Query = (from z in hospitalEntities.Users
                         where z.UserName == UserNameTxt.Text && z.Password == PasswordTxt.Text
                         select z).Count();
            if (Query == 1)
            {
                Main mainform = new Main();
                mainform.UserNameL = UserNameTxt.Text;
                mainform.Role = PasswordTxt.Text;
                mainform.Show();
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
            
            //foreach (var user in hospitalEntities.Users)
            //{
            //    if (user.UserName == UserNameTxt.Text && user.Password == PasswordTxt.Text)
            //    {
            //        
            //        mainform.UserName = user.UserName;
            //        mainform.Role = user.role;
            //        UserNameTxt.Text = "";
            //        PasswordTxt.Text = "";
            //    }
            //    else if (user.UserName != UserNameTxt.Text || user.Password != PasswordTxt.Text)
            //    {
            //        LogcheckTxt.Text = "The user name or password is wrong";
            //        LogcheckTxt.Visible = true;
            //        this.UserNameTxt.Text = "";
            //        PasswordTxt.Text = "";
            //    }
            //}
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if(UserNameTxt.Text.Length >= 1)
            {
                LogcheckTxt.Visible = false;
            }
        }
    }
}
