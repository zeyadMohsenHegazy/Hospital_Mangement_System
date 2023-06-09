using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    public static class TestDashBoardProp
    {
        //dashboard test
        public static int NumOfAdmins { get; set; }
        public static int NumOfUsers { get; set; }
        public static int NumOfDocs { get; set; }
        public static int NumOfPatients { get; set; }


        //Doctor custom control test
        public static string DoctorFirstName { get; set; }
        public static string DoctorLastName { get; set; }
        public static int DoctorSalary { get; set; }


        //Confirm reservation custom control
        public static int PatientID { get; set; }
        public static string PatientFirstName { get; set; }
        public static string PatientLastName { get; set; }
        public static DateTime ReservDate { get; set; }
    }
}
