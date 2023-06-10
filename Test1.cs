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
            //Arange
            int expectedDoctors = 6;
            int expectedAdmins = 6;
            int expectedUsers = 5;
            int expectedPatients = 25;

            //Act
            int actualDoctors = TestDashBoardProp.NumOfDocs;
            int actualAdmins = TestDashBoardProp.NumOfAdmins;
            int actualUsers = TestDashBoardProp.NumOfUsers;
            int actualPatients = TestDashBoardProp.NumOfPatients;

            //Assert
            if (actualDoctors == expectedDoctors)
            {
                MessageBox.Show("Test for number of doctors passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for number of doctors failed. ✘ Expected {expectedDoctors}, actual {actualDoctors}.");
            }

            if (actualAdmins == expectedAdmins)
            {
                MessageBox.Show("Test for number of admins passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for number of admins failed. ✘ Expected {expectedAdmins}, actual {actualAdmins}.");
            }

            if (actualUsers == expectedUsers)
            {
                MessageBox.Show("Test for number of users passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for number of users failed. ✘ Expected {expectedUsers}, actual {actualUsers}.");
            }

            if (actualPatients == expectedPatients)
            {
                MessageBox.Show("Test for number of patients passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for number of patients failed. ✘ Expected {expectedPatients}, actual {actualPatients}.");
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
                MessageBox.Show("Test for doctor first name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for doctor's First Name failed. ✘ Expected {expectedFirstName} , actual {actualFirstName}.");
            }

            if (actualLastName == expectedLastName)
            {
                MessageBox.Show("Test for Doctor's last name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Doctor's last name failed. ✘ Expected {expectedLastName} , actual {actualLastName}.");
            }

            if (actualSalary == expectedSalary)
            {
                MessageBox.Show("Test for Doctor's Salary passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for doctor's Salary failed. ✘ Expected {expectedSalary} , actual {actualSalary}.");
            }


        }

        //test for the confirmation of reservation custom control 
        private void TestConfResr_Click(object sender, EventArgs e)
        {

            int expectedID = 1025;
            string expectedFirstName = "Josef";
            string expectedLastName = "abdo";
            string expectedDate = "24-06-2023";


            int actualPatientID = TestDashBoardProp.PatientID; 
            string actualFirstName = TestDashBoardProp.PatientFirstName;
            string actualLastName = TestDashBoardProp.PatientLastName;
            string actualDate = TestDashBoardProp.ReservDate.ToString("dd-MM-yyyy");

            if (actualPatientID == expectedID)
            {
                MessageBox.Show("Test for Patient ID passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient ID failed. ✘ Expected {expectedID} , actual {actualPatientID}.");
            }


            if (actualFirstName == expectedFirstName)
            {
                MessageBox.Show("Test for Patient first name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient First Name failed. ✘ Expected {expectedFirstName} , actual {actualFirstName}.");
            }


            if (actualLastName == expectedLastName)
            {
                MessageBox.Show("Test for Patient Last Name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Last Name failed. ✘ Expected {expectedLastName} , actual {actualLastName}.");
            }


            if (actualDate == expectedDate)
            {
                MessageBox.Show("Test Patient reservation Date passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Reservation Date failed. ✘ Expected {expectedDate} , actual {actualDate}.");
            }

        }

        //test patient Custom control
        private void TestPatientsCC_Click(object sender, EventArgs e)
        {

            int expectedID = 1025;
            string expectedFirstName = "josef";
            string expectedLastName = "abdo";
            int expectedAge = 27;
            string expectedGender = "m";
            string expectedBloodType = "AB ";
            string expectedPhone = "01222606281";
            string expectedEmail = "josephserafem@gmail.com";
            
            int actualPatientID = TestDashBoardProp.PatientID1;
            string actualFirstName = TestDashBoardProp.PatientFirstName1;
            string actualLastName = TestDashBoardProp.PatientLastName1;
            int actualAge = TestDashBoardProp.PatientAge;
            string actualGender = TestDashBoardProp.PatientGender;
            string actualBloodType = TestDashBoardProp.PatientBloodType;
            string actualPhone = TestDashBoardProp.PatientPhone;
            string actualEmail = TestDashBoardProp.PatientEmail;

            if (actualPatientID == expectedID)
            {
                MessageBox.Show("Test for Patient ID passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient ID failed. ✘ Expected {expectedID} , actual {actualPatientID}.");
            }


            if (actualFirstName == expectedFirstName)
            {
                MessageBox.Show("Test for Patient first name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient First Name failed. ✘ Expected {expectedFirstName} , actual {actualFirstName}.");
            }


            if (actualLastName == expectedLastName)
            {
                MessageBox.Show("Test for Patient Last Name passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Last Name failed. ✘ Expected {expectedLastName} , actual {actualLastName}.");
            }


            if (actualAge == expectedAge)
            {
                MessageBox.Show("Test Patient Age  passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Age failed. ✘ Expected {expectedAge} , actual {actualAge}.");
            }
            

            if (actualGender == expectedGender)
            {
                MessageBox.Show("Test Patient Gender  passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Gender failed. ✘ Expected {expectedGender} , actual {actualGender}.");
            }


            if (actualBloodType == expectedBloodType)
            {
                MessageBox.Show("Test Patient Blood Type  passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Blood Type failed. ✘ Expected {expectedBloodType} , actual {actualBloodType}.");
            }


            if (actualPhone == expectedPhone)
            {
                MessageBox.Show("Test Patient Phone  passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Phone failed. ✘ Expected {expectedPhone} , actual {actualPhone}.");
            }


            if (actualEmail == expectedEmail)
            {
                MessageBox.Show("Test Patient Age  passed. ✔");
            }
            else
            {
                MessageBox.Show($"Test for Patient Age failed. ✘ Expected {expectedEmail} , actual {actualEmail}.");
            }


        }
    }
}
