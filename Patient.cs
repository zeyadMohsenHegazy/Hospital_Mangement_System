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
    public partial class Patient : UserControl
    {
        HospitalEntities hospital;
        public Patient()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string Phone = PhoneTxt.Text;
            var data = hospital.Patiens.Where(p => (p.FirstName == firstName && p.LastName == lastName) || p.phone == Phone).FirstOrDefault();
            IDTxt.Text = data.ID.ToString();
            label1.Text = data.FirstName;
            label2.Text = data.LastName;
            label3.Text = data.Age.ToString();
            label4.Text = data.Gender.Equals("f") ? "FEMALE" : "MALE";
            label5.Text = data.BloodType;
            label6.Text = data.phone;
            label7.Text = data.email;

            Clear();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            FirstNameTxt.Text = string.Empty;
            LastNameTxt.Text = string.Empty;
            PhoneTxt.Text = string.Empty;
        }
    }
}
