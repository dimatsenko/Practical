using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCalculations
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            return (Math.Tan(x + 1) * Math.Tan(x + 1)) / (Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x);
        }

        private double f2(double x)
        {
            return (2 * x + 2) / (Math.Tan(2 * x - 1) + 1);
        }

        private double f3(double x)
        {
            return (Math.Cos(x + 2) * Math.Cos(x + 2)) / (Math.Pow(Math.E, -2 * x) + Math.Pow(3 * x * x + 1, 1/4));
        }


        public void tab(double xn = -1.9, double xk = 29.7, double h = 0.1, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else 
                {
                    if ((x >= 0) && (x < a))
                     {
                    y = f2(x);
                     }
                else
                
                    y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}