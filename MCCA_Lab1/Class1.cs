using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCA_Lab1
{
    abstract class Class1
    {
        public delegate double Fun1(double x, double y);
        public funk F2 = new funk();
        public abstract int Sraw( double[,] X_Y, Fun1 F1, Fun1 F3);
    }
}
