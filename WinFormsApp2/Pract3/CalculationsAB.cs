using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract3
{
    public class CalculationsAB
    {
        private int a;
        private int b;

        public CalculationsAB(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get { return a; } }
        public int B { get { return b; } }

        public int Count()
        {
            int count = 0;

            for (int i = a; i <= b; i++)
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
