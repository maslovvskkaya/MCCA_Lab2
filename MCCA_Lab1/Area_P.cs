using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCA_Lab1
{
    class Area_P : Analiz
    {
        double kol_p, kol_G;
        public Area_P()
        {
        }
        public Area_P(double kol_p, double kol_G)
        {
            this.kol_p = kol_p;
            this.kol_G = kol_G;
        }
        // Метод визначення площі фігури
        public override double Area(double Xmax, double Xmin,
        double Ymax, double Ymin)
        {
            return (this.kol_p / this.kol_G) * base.Area(Xmax,
            Xmin, Ymax, Ymin);
        }
    }
}
