using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract4
{
    internal class FileWrite : IWrite
    {
        public void Write(string path, ArraysAB a)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in a.b)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }

    }
}
