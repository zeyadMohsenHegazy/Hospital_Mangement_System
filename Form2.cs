using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class Main : Form
    {
        public string UserNameL;
        public string Role;
        public Main()
        {
            InitializeComponent();
        }
        private void movepanel(Control Btn)
        {
            PanelMovable.Top = Btn.Top;
            PanelMovable.Height = Btn.Height;

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            movepanel(PatientBtn);
            SettingsTapCustomControl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.ToString("dd-MMM-yyyy hh-mm-ss tt");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HospitalEntities hospital = new HospitalEntities();
            var users = hospital.Users;
            foreach(var item in users)
            {
                if(item.UserName == UserNameL)
                {
                    if (item.role == "receptionist")
                    {
                        DashBoardBtn.Visible = false;
                        SettingsBtn.Visible = false;
                    }
                }
            }
            timer1.Start();
            UserNameLabel.Text = UserNameL;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            movepanel(DoctorBtn);
            SettingsTapCustomControl.Visible = false;
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            movepanel(DepartmentBtn);
            SettingsTapCustomControl.Visible = false;
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            movepanel(ReservationBtn);
            SettingsTapCustomControl.Visible = false;
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            movepanel(DashBoardBtn);
            SettingsTapCustomControl.Visible = false;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            movepanel(SettingsBtn);
            SettingsTapCustomControl.Visible = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            movepanel(ReportsBtn);

        }
    }
}
