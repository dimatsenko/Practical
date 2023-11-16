using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract4
{
    public class ArraysAB
    {
        public int[] a;
        public int[] b;
        public int Length { get; set; }

        public ArraysAB(int n)
        {
            a = new int[n];
        }
        public string DetermineSituation()
        {
            bool allZeros = true;
            bool firstPositive = false;
            bool firstNegative = false;

            foreach (int number in a)
            {
                if (number != 0)
                {
                    allZeros = false;

                    if (number > 0)
                    {
                        firstPositive = true;
                    }
                    else
                    {
                        firstNegative = true;
                    }

                    break;
                }
            }

            if (allZeros)
            {
                return "Всі числа нулі.";
            }
            else if (firstPositive)
            {
                return "Перше ненульове число додатнє.";
            }
            else if (firstNegative)
            {
                return "Перше ненульове число від'ємне.";
            }

            return "Невідомо.";
        }
    }
}