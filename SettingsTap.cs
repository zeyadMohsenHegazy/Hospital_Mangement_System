using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            //username and password patterns
            string usernamePattern = @"^\w{4,}$";
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";

            string name = UserNameTxt.Text.Trim();
            string pass = PasswordTxt.Text.Trim();
            string Role = RoleList.SelectedItem.ToString();
            if (!(Regex.IsMatch(name, usernamePattern)) || (!Regex.IsMatch(pass, passwordPattern) ))
            {
                //warring message
                MessageBox.Show("-Username must be at least 4 characters. " +
                    "\n-Password must be at least 8 characters long and contain " +
                    "at least one uppercase letter, one lowercase letter, one digit, " +
                    "and one special character.","Required Field!", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            }
            else
            {
                hospitalEntities.Users.Add(new User() { UserName = name, Password = pass, role = Role });
                hospitalEntities.SaveChanges();
                ClearTxtBoxesUserTap();

            }
        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {

            string DepartNamePattern = @"^\w{3,}$";

            string DepartName = DepartmentNameTxt.Text;
            int DepartNumber = int.Parse(DepartmentNumberTxt.Text);
            if (!(Regex.IsMatch(DepartName, DepartNamePattern)) || (DepartNumber.ToString().Length != 3))
            {
                MessageBox.Show("-Department Name must be at least 3 characters. \n- Depatment Number Should be 3 Numbers", "Required Field!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                hospitalEntities.Departments.Add(new Department() { Number = DepartNumber, Name = DepartName });
                hospitalEntities.SaveChanges();

                ClearTxtBoxesDepartTap();
            }   
        }

        private void AddDoctorBtn_Click(object sender, EventArgs e)
        {
            //patterns
            string DoctorFNamePattern = @"^\w{4,}$";
            string DoctorLNamePattern = @"^\w{4,}$";

            string DoctorFName = DoctorFirstNameTxt.Text;
            string DoctorLName = DoctorLastNameTxt.Text;
            int DoctorSalary = int.Parse(DoctorSalaryTxt.Text);
            string DoctorSpecialization = DoctorSpecializationTxt.Text;
            if (!(Regex.IsMatch(DoctorFName, DoctorFNamePattern)) || !(Regex.IsMatch(DoctorLName, DoctorLNamePattern)) || DoctorSalary <= 2500 )
            {
                MessageBox.Show("-Doctor First Name must be at least 4 characters. \n-Doctor Last Name must be at least 3 characters. \n- Doctor Salary must be more than 2500", "Required Field!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                hospitalEntities.Doctors.Add(new Doctor() { FirstName = DoctorFName, LastName = DoctorFName, Salary = DoctorSalary, Specialization = DoctorSpecialization });
                hospitalEntities.SaveChanges();

                ClearTxtBoxesDoctorTap();
            }
            
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

        private void DoctorSalaryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // If not, reject the input by setting the Handled property to true
                e.Handled = true;
            }
        }

        private void DepartmentNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
