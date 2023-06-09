using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class Reports_ChartsCustomControl : UserControl
    {
        HospitalEntities hospital;
        public Reports_ChartsCustomControl()
        {
            InitializeComponent();
            hospital = new HospitalEntities();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            DailyReport report = new DailyReport();
            report.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ChartsForm chartsForm = new ChartsForm();
            chartsForm.Show();
        }
    }
}
