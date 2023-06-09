using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class ReservationsCustomControl : UserControl
    {
        public Dictionary<int, string> DepatmentsAndDepartmentsId = new Dictionary<int, string>();
        HospitalEntities hospital;
        int ResrvationAmountMoney;
        int DoctorId;
        int DepartID;
        public string _SystemUserName { get; set; }
        public ReservationsCustomControl()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
            DepatmentsAndDepartmentsId.Add(1003, "dental");
            DepatmentsAndDepartmentsId.Add(1004, "surgery");
            DepatmentsAndDepartmentsId.Add(1005, "pediatric");
            DepatmentsAndDepartmentsId.Add(1006, "neurology");
            DepatmentsAndDepartmentsId.Add(1007, "gynecology");
            DepatmentsAndDepartmentsId.Add(1008, "orthopedic");
        }



        //to get the departid from the department name
        public int GetDepartmentID(string DeptName)
        {
            foreach(var item in DepatmentsAndDepartmentsId)
            {
                if(item.Value == DeptName)
                {
                    DepartID = item.Key;
                }
            }
            return DepartID;
        }


        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            #region patients table informantions
            string PatientFName = FNameTxt.Text.Trim();
            string PatientLName = LNameTxt.Text.Trim();
            int PatientAge = int.Parse(AgeTxt.Text);
            string Patientphone = PhoneTxt.Text.Trim();
            string PatientEmail = EmailTxt.Text.Trim();
            string Gender = GenderListBox.SelectedItem.ToString();
            string PatientDBGender = "";
            if (Gender == "Male")
            {
                PatientDBGender = "m";
            }
            else
                PatientDBGender = "f";
            string PatientBloodType = BloodTypeListBox.SelectedItem.ToString();
            #endregion

            #region reservation table informations
            string ReservationType = ReservationListBox.SelectedItem.ToString();
            string DepartmentName = DepartmentNameListBox.SelectedItem.ToString();

            DateTime PatientExaminDate = ReservationDateTimePicker.Value.Date;
            int DepartmentID = GetDepartmentID(DepartmentName);
            int _PatientID = GetPatientIdBasedInFirstName();
            int _UserID = GetUserIdBasedInUserName();
            #endregion

            #region dealing with the data base (reservations table and patient table)


            //insert into table patient
            hospital.Patiens.Add(new Patien()
            {
                FirstName = PatientFName,
                LastName = PatientLName,
                Age = PatientAge,
                Gender = PatientDBGender,
                BloodType = PatientBloodType,
                phone = Patientphone,
                email = PatientEmail
            });
            hospital.SaveChanges();
            //to get userID
            
            //to get pateintID
            //insert into table reservations
            hospital.Reservations.Add(new Reservation() 
            {   PaymentMethod = "cash",
                ReservationPrice = ResrvationAmountMoney,
                MeetTime = PatientExaminDate,
                UserID = _UserID,
                PatientID = _PatientID,
                DoctorID = DoctorId,
                DepartmentID = DepartmentID
            });
            #endregion
            
            hospital.SaveChanges();
            clearall();
        }

        private void ReservationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTheResevationAmunt();
        }


        //to calculate the reservation amount based into
        //it is normal reservation or Urgont one :)
        public void CalculateTheResevationAmunt()
        {
            if (ReservationListBox.SelectedIndex == 0)
            {
                ReservationAmountLable.Text = "50 L.E";
                ResrvationAmountMoney = 50;
            }
            else
            {
                ReservationAmountLable.Text = "80 L.E";
                ResrvationAmountMoney = 80;

            }
        }

        //to reset the form
        public void clearall()
        {
            FNameTxt.Text = "";
            LNameTxt.Text = "";
            AgeTxt.Text = "";
            PhoneTxt.Text = "";
            EmailTxt.Text = "";
            GenderListBox.SelectedIndex = 0;  
            BloodTypeListBox.SelectedIndex = 0;
            ReservationListBox.SelectedIndex = 0;
            DoctorNameListBox.SelectedIndex = 0;
            DepartmentNameListBox.SelectedIndex = 0;
        }


        //to get automatically the doctors names of the selected depatment 
        private void DepartmentNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Department = DepartmentNameListBox.SelectedItem.ToString();

            var MachingDoctors = from Doctor in hospital.Doctors
                                 where Doctor.Specialization == Department
                                 select Doctor;
            DoctorId = MachingDoctors.FirstOrDefault().ID;
            
            List <String> list = new List <String>(0);
            DoctorNameListBox.DataSource = list;
            DoctorNameListBox.DataSource = MachingDoctors.ToList();
        }
    
        public int GetUserIdBasedInUserName()
        {
            var Users = hospital.Users.ToList();
            foreach(var user in Users)
            {
                if(user.UserName == _SystemUserName)
                {
                    return user.ID;
                }
            }
            return 1;
        }
    
        public int GetPatientIdBasedInFirstName()
        {
            var patients = hospital.Patiens.ToList();
            if (patients.Count == 0)
            {
                return 1; 
            }
            else
            {
                int lastPatientId = patients.LastOrDefault().ID; 
                return lastPatientId + 1; 
            }
        }

    }
}
