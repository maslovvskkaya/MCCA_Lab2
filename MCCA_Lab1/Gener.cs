using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCA_Lab1
{
    class Gener
    {
        double Xmin, Xmax, Ymin, Ymax;
        int KOL;
        public Gener() { }
        public Gener(double Xmin, double Xmax, double Ymin, double Ymax, int KOL)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;
            this.Ymin = Ymin;
            this.Ymax = Ymax;
            this.KOL = KOL;
        }
        public double[,] Generator()
        {
            double[,] MAS_XY = new double[this.KOL, 2];
            Random ob3 = new Random();
            for (int i = 0; i < this.KOL; i++)
            {
                MAS_XY[i, 0] = ob3.NextDouble();
                MAS_XY[i, 1] = ob3.NextDouble();
            }
            return MAS_XY;
        }
    }
}
