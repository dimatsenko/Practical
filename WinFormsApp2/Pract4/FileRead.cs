using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract4
{
    internal class FileRead : IRead
    {
        public void Read(string path, ArraysAB a)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = "";
                try
                {
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] elements = line.Split(' '); // Use the appropriate delimiter
                        foreach (string element in elements)
                        {
                            a.a[i] = Convert.ToInt32(element);
                            i++;
                        }
                    }
                    a.Length = i;
                    sr.Close();
                }
                catch
                {
                    throw new AccessViolationException("Error in file");
                }
            }
        }
    }
}
