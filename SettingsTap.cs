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
    public partial class SettingsTap : UserControl
    {
        HospitalEntities hospitalEntities;
        public SettingsTap()
        {
            InitializeComponent();
            hospitalEntities = new HospitalEntities();
        }

       
        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
             
            string name = UserNameTxt.Text;
            string pass = PasswordTxt.Text;
            var selectedItems = RoleList.SelectedItems;
            string Role = "";
            foreach (var selectedItem in selectedItems)
            {
                Role = selectedItem.ToString();
            }

            hospitalEntities.Users.Add(new User() { UserName = name, Password = pass, role = Role });
            hospitalEntities.SaveChanges();

            ClearTxtBoxesUserTap();
        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            string DepartName = DepartmentNameTxt.Text;
            int DepartNumber = int.Parse(DepartmentNumberTxt.Text);

            hospitalEntities.Departments.Add(new Department() { Number=DepartNumber ,Name=DepartName });
            hospitalEntities.SaveChanges();

            ClearTxtBoxesDepartTap();
        }

        private void AddDoctorBtn_Click(object sender, EventArgs e)
        {
            string DoctorFName = DoctorFirstNameTxt.Text;
            string DoctorLName = DoctorLastNameTxt.Text;
            int DoctorSalary = int.Parse(DoctorSalaryTxt.Text);
            string DoctorSpecialization = DoctorSpecializationTxt.Text;

            hospitalEntities.Doctors.Add(new Doctor() { FirstName=DoctorFName, LastName=DoctorFName, Salary= DoctorSalary, Specialization=DoctorSpecialization });
            hospitalEntities.SaveChanges();

            ClearTxtBoxesDoctorTap();
        }


        //clear the text boxes in each tap :)
        public void ClearTxtBoxesUserTap()
        {
            UserNameTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
        }
        public void ClearTxtBoxesDoctorTap()
        {
            DoctorFirstNameTxt.Text = string.Empty;
            DoctorLastNameTxt.Text = string.Empty;
            DoctorSalaryTxt.Text = string.Empty;
            DoctorSpecializationTxt.Text = string.Empty;
        }
        public void ClearTxtBoxesDepartTap()
        {
            DepartmentNameTxt.Text = string.Empty;
            DepartmentNumberTxt.Text = string.Empty;
        }
    }
}
