using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract3
{
    public class CalculationsABC

    {
        public CalculationsABC(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        int a, b, c;
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public int D()
        {
            int[] values = new int[] { a, b, c };
            int count = 0;

            foreach (int value in values)
            {
                if (value % 27 == 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
