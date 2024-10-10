using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MCCA_Lab1
{
    class Graf : Analiz
    {
        double Xmin, Xmax, Ymin, Ymax;
        public Graf()
        {
        }
        public Graf(double Xmin, double Xmax, double Ymin, double
        Ymax)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;
            this.Ymin = Ymin;
            this.Ymax = Ymax;
        }
        public void Grafik(Chart chart1)
        {
            chart1.Series.Clear();

            for (double i = Xmin; i <= Xmax; i++)
            {
                if (i > 0)
                {
                    double y = (2 / 3) * Math.Cos(i);
                    chart1.Series[0].Points.AddXY(i, y);
                }
            }

            for (double i = Xmin; i <= Xmax; i++)
            {
                if (i > 0)
                {
                    double y = Math.Tan(i);
                    chart1.Series[1].Points.AddXY(i, y);
                }
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisY.Minimum = Ymin;
            chart1.ChartAreas[0].AxisY.Maximum = Ymax;
        }
    }
}
