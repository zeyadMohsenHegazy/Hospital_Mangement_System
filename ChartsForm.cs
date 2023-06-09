using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }
        

        private void ChartsForm_Load(object sender, EventArgs e)
        {

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                         Values = new ChartValues<ObservablePoint>
                         {

                                new ObservablePoint(1,1),
                                new ObservablePoint(6,3),
                                new ObservablePoint(7,3),
                                new ObservablePoint(8,1),
                                new ObservablePoint(9,5),
                                new ObservablePoint(10,4),
                                new ObservablePoint(15,1),
                                new ObservablePoint(16,1),

                         },
                            PointGeometrySize = 25
                    },
                };

        }
       
    } 
}
