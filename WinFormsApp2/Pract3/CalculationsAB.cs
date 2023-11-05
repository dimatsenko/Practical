using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract3
{
    public class CalculationsAB
    {
        private double a;
        private double b;

        public CalculationsAB(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get { return a; } }
        public double B { get { return b; } }

        public int Count()
        {
            int count = 0;

            for (int i = (int)a; i <= (int)b; i++)
            {
                if (i % 2 == 0 && i % 3 == 2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
