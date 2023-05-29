using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
       
            HospitalEntities H = new HospitalEntities();
            var items = H.Doctors.Select(z => z.FirstName);
            foreach(var item in items)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
