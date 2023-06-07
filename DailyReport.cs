using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class DailyReport : Form
    {
        HospitalEntities hospital;
        public DailyReport()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now.Date;
            var show_daily = from d in hospital.Reservations
                             join c in hospital.Patiens
                              on d.PatientID equals c.ID
                             join z in hospital.Departments
                             on d.DepartmentID equals z.ID

                             where EntityFunctions.TruncateTime(d.MeetTime) == currentDate
                             select new { PaientName = c.FirstName + " " + c.LastName, DepartmentName = z.Name, ReservationPrice = d.ReservationPrice, paymentmethod = d.PaymentMethod, PatienPhone = c.phone, PaientAge = c.Age, PatientGender = c.Gender };

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.Columns.Add("Patient Name", typeof(string));
            dt.Columns.Add("Department name", typeof(string));
            dt.Columns.Add("Reservation Price", typeof(int));
            dt.Columns.Add("paymentmethod", typeof(string));
            dt.Columns.Add("Patien Phone", typeof(string));
            dt.Columns.Add("Patien Age", typeof(string));
            dt.Columns.Add("Patien Gender", typeof(string));
            dt.Columns.Add("Total Money", typeof(int));

            decimal TotalSum = 0;
            foreach (var item in show_daily)
            {
                dt.Rows.Add(item.PaientName, item.DepartmentName, item.ReservationPrice, item.paymentmethod, item.PatienPhone, item.PaientAge, item.PatientGender);
                TotalSum += item.ReservationPrice;
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Daily.xml");

            todayRoport1.SetDataSource(ds);
            todayRoport1.SetParameterValue("TotalMoney", TotalSum);
            crystalReportViewer1.ReportSource = todayRoport1;
            crystalReportViewer1.Refresh();
        }
    }
}
