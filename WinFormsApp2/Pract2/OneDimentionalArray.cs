using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Pract2
{
    internal class NovemberTemperatureData
    {
        private double[] temperatureData; // Масив для збереження даних про температуру


        public NovemberTemperatureData(double[] data)
        {
            if (data.Length != 10)
            {
                throw new ArgumentException("Масив даних має містити 10 значень.");
            }

            temperatureData = data;
        }
        public int CountDaysBelowMinus10()
        {
            int count = 0;
            foreach (double temperature in temperatureData)
            {
                if (temperature < -10)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
