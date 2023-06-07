using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class DepartmentCustomControl : UserControl
    {
        HospitalEntities hospital;
        public DepartmentCustomControl()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {

            #region SQL command
            //foreach (Panel panel in Controls.OfType<Panel>())
            //{
            //    string Name = panel.Name;
            //    string Status = panel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Name.Substring(2);

            //    SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM dbo.Department WHERE Name = '{Name}'");
            //    int count = (int)command.ExecuteScalar();
            //    if (count == 0)
            //    {
            //        command = new SqlCommand($"INSERT INTO Department (Name, Status) VALUES ('{Name}', '{Status}')");
            //        command.ExecuteNonQuery();
            //    }
            //    else
            //    {
            //        command = new SqlCommand($"SELECT Status FROM dbo.Department WHERE Name = '{Name}'");
            //        string currentStatus = (string)command.ExecuteScalar();
            //        if (currentStatus != Status)
            //        {
            //            command = new SqlCommand($"UPDATE dbo.Department SET Status = '{Status}' WHERE Name = '{Name}'");
            //            command.ExecuteNonQuery();
            //        }
            //    }
            //}
            #endregion
            #region MyRegion

            //var panels = Controls.OfType<Panel>();

            //foreach (var panel in panels)
            //{
            //    string name = panel.Name;
            //    string status = panel.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked)?.Name.Substring(2);
            //    //var checkedRadioButtons = panel.Controls.OfType<RadioButton>().Where(rb => rb.Checked);


            //    //foreach (var radioButton in checkedRadioButtons)
            //    //{
            //    //    string status = radioButton.Name;
            //    //}

            //    var department = hospital.Departments.FirstOrDefault(d => d.Name == name);
            //        if (department == null)
            //        {
            //            hospital.Departments.Add(department);
            //        }
            //        else if (department.Status != status)
            //        {
            //            department.Status = status;
            //        }
            //        hospital.SaveChanges();

            //} 
            #endregion

            foreach (var panel in Controls.OfType<Panel>())
            {
                string name = panel.Name;
                RadioButton checkedRadioButton = panel.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked);
                string status = checkedRadioButton != null ? checkedRadioButton.Name.Substring(2) : null;

                var department = hospital.Departments.FirstOrDefault(d => d.Name == name);
                if (department == null)
                {
                    department = new Department { Name = name, Status = status };
                    hospital.Departments.Add(department);
                }
                else if (status != null && department.Status != status)
                {
                    department.Status = status;
                }
                hospital.SaveChanges();
            }

        }
    }
}
