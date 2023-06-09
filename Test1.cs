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
    public partial class Test1 : Form
    {
        private DashBoard dashboard;
       
        public Test1()
        {
            InitializeComponent();
        }

        //test for the Dashboard Custom conrol 
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            int expectedDoctors = 6;
            int expectedAdmins = 6;
            int expectedUsers = 5;
            int expectedPatients = 25;


            int actualDoctors = TestDashBoardProp.NumOfDocs;
            int actualAdmins = TestDashBoardProp.NumOfAdmins;
            int actualUsers = TestDashBoardProp.NumOfUsers;
            int actualPatients = TestDashBoardProp.NumOfPatients;

            if (actualDoctors == expectedDoctors)
            {
                MessageBox.Show("Test for number of doctors passed.");
            }
            else
            {
                MessageBox.Show($"Test for number of doctors failed. Expected {expectedDoctors}, actual {actualDoctors}.");
            }

            if (actualAdmins == expectedAdmins)
            {
                MessageBox.Show("Test for number of admins passed.");
            }
            else
            {
                MessageBox.Show($"Test for number of admins failed. Expected {expectedAdmins}, actual {actualAdmins}.");
            }

            if (actualUsers == expectedUsers)
            {
                MessageBox.Show("Test for number of users passed.");
            }
            else
            {
                MessageBox.Show($"Test for number of users failed. Expected {expectedUsers}, actual {actualUsers}.");
            }

            if (actualPatients == expectedPatients)
            {
                MessageBox.Show("Test for number of patients passed.");
            }
            else
            {
                MessageBox.Show($"Test for number of patients failed. Expected {expectedPatients}, actual {actualPatients}.");
            }
        }

        //test for the Doctors custom control 
        private void TestDoctor_Click(object sender, EventArgs e)
        {


            string expectedFirstName = "esraa";
            string expectedLastName = "mohsen";
            int expectedSalary = 8000;


            string actualFirstName = TestDashBoardProp.DoctorFirstName;
            string actualLastName = TestDashBoardProp.DoctorLastName;
            int actualSalary = TestDashBoardProp.DoctorSalary;


            if (actualFirstName == expectedFirstName)
            {
                MessageBox.Show("Test for doctor first name passed.");
            }
            else
            {
                MessageBox.Show($"Test for doctor's First Name failed. Expected {expectedFirstName} , actual {actualFirstName}.");
            }

            if (actualLastName == expectedLastName)
            {
                MessageBox.Show("Test for doctor last name passed.");
            }
            else
            {
                MessageBox.Show($"Test for Doctor's last name failed. Expected {expectedLastName} , actual {actualLastName}.");
            }

            if (actualSalary == expectedSalary)
            {
                MessageBox.Show("Test for Doctor's Salary passed.");
            }
            else
            {
                MessageBox.Show($"Test for doctor's Salary failed. Expected {expectedSalary} , actual {actualSalary}.");
            }


        }

        //test for the confirmation of reservation custom control 
        private void TestConfResr_Click(object sender, EventArgs e)
        {

            int expectedID = 21;
            string expectedFirstName = "kero";
            string expectedLastName = "fayez";
            string expectedDate = "09-06-2023";


            int actualPatientID = TestDashBoardProp.PatientID; 
            string actualFirstName = TestDashBoardProp.PatientFirstName;
            string actualLastName = TestDashBoardProp.PatientLastName;
            string actualDate = TestDashBoardProp.ReservDate.ToString("dd-MM-yyyy");

            if (actualPatientID == expectedID)
            {
                MessageBox.Show("Test for Patient ID passed.");
            }
            else
            {
                MessageBox.Show($"Test for Patient ID failed. Expected {expectedID} , actual {actualPatientID}.");
            }


            if (actualFirstName == expectedFirstName)
            {
                MessageBox.Show("Test for Patient first name passed.");
            }
            else
            {
                MessageBox.Show($"Test for Patient First Name failed. Expected {expectedFirstName} , actual {actualFirstName}.");
            }


            if (actualLastName == expectedLastName)
            {
                MessageBox.Show("Test for Patient Last Name passed.");
            }
            else
            {
                MessageBox.Show($"Test for Patient Last Name failed. Expected {expectedLastName} , actual {actualLastName}.");
            }


            if (actualDate == expectedDate)
            {
                MessageBox.Show("Test Patient reservation Date passed.");
            }
            else
            {
                MessageBox.Show($"Test for Patient Reservation Date failed. Expected {expectedDate} , actual {actualDate}.");
            }


        }
    }
}
