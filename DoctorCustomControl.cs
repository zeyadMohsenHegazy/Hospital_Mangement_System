using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class DoctorCustomConrol : System.Windows.Forms.UserControl
    {
        HospitalEntities hospital;
        public DoctorCustomConrol()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            string docName = DoctorFullNameTxt.Text;
            string stname = docName.Substring(0, docName.IndexOf(" "));
            string lsname = docName.Substring(stname.Length + 1).Trim();

            var docs = hospital.Doctors.Where(d => d.FirstName == stname && d.LastName == lsname).First();

            label1.Text = docs.FirstName;
            label2.Text = docs.LastName;
            label3.Text = docs.Salary.ToString();
            label4.Text = docs.Specialization;

            TestDashBoardProp.DoctorFirstName = docs.FirstName;
            TestDashBoardProp.DoctorLastName = docs.LastName;
            TestDashBoardProp.DoctorSalary = docs.Salary;

        }

        private void DoctorFullNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                AddNewUserBtn_Click(sender, e);
            }
        }

        private void DoctorFullNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (DoctorFullNameTxt.Text.Length == 1)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
            }
        }

       
    }
}
