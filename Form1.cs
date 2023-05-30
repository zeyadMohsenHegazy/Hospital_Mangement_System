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
            var users = hospitalEntities.Users;
            string User = UserName.Text;
            string Pass = Password.Text;
            foreach (var user in users)
            {
                if (user.UserName == User && user.Password == Pass)
                {
                    MessageBox.Show("Logged");
                    UserName.Text = String.Empty;
                    Password.Text = String.Empty;
                }
                else if (user.UserName != User || user.Password != Pass)
                {
                    LogcheckTxt.Text = "The user name or password is wrong";
                    LogcheckTxt.Visible = true;
                    UserName.Text = String.Empty;
                    Password.Text = String.Empty;
                }
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if(UserName.Text.Length >= 1)
            {
                LogcheckTxt.Visible = false;
            }
        }


    }
}
