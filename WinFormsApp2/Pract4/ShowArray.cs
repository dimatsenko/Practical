using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract4
{
    internal class ShowArray
    {
        public string WriteArray(int[] array)
        {
            string s = "";
            foreach (int i in array)
            {
                s += i.ToString() + ", ";
            }
            return s;
        }
    }
}
