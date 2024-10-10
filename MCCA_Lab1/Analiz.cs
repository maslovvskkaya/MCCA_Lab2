using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCA_Lab1
{
    class Analiz : Class1
    {
       
override public int Sraw(double[,] X_Y, Fun1 F1, Fun1 F_1)
        {
            int KOL_p = 0;
            int dl = X_Y.GetLength(0);
            for (int i = 0; i < dl; i++)
            {
                if (F1(X_Y[i, 1], X_Y[i, 0])>= Math.Tan(i) && F_1(X_Y[i,1], X_Y[i, 0]) <= (2/3)*Math.Cos(i))
                {
                    KOL_p++;
                }
            }
            return KOL_p;
        }
        // Розрахунок площі базового прямокутника
        public virtual double Area(double Xmax, double Xmin, double Ymax,
        double Ymin)
        {
            return (Xmax - Xmin) * (Ymax - Ymin);
        }
    }
}

