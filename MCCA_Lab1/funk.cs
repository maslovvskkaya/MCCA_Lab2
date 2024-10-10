using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCA_Lab1
{
    internal class funk
    {
        public double F(double x, double y)
        {
            return Math.Tan(x);
        }
        public double F_1(double x, double y)
        {
            return (2 / 3) * Math.Cos(x);
        }
    }
}
