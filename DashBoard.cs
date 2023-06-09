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
    public partial class DashBoard : UserControl
    {
        HospitalEntities hospital;
        public DashBoard()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }



        public void LoadData()
        {
            int Doctors = hospital.Doctors.Count();
            NumOfDoctors.Text = Doctors.ToString();
            TestDashBoardProp.NumOfDocs = Doctors;

            int Patints = hospital.Patiens.Count();
            NumOfPatients.Text = Patints.ToString();
            TestDashBoardProp.NumOfPatients = Patints;

            int AdminUsers = hospital.Users.Count(z => z.role == "admin");
            NumOfAdmins.Text = AdminUsers.ToString();
            TestDashBoardProp.NumOfAdmins = AdminUsers;

            int ReceptianistUsers = hospital.Users.Count(z => z.role == "receptionist");
            NumOfUsers.Text = ReceptianistUsers.ToString();
            TestDashBoardProp.NumOfUsers = ReceptianistUsers;
        }



        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
