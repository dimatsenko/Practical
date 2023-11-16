using Pract.Pract4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTest
{
    [TestClass]
    public class ArraysABTests
    {
        [TestMethod]
        public void DetermineSituation_AllZeros()
        {
            ArraysAB arrayExample = new ArraysAB(5); // Assuming an array of size 5 with all zeros

            string result = arrayExample.DetermineSituation();

            Assert.AreEqual("All numbers are zero.", result);
        }

        [TestMethod]
        public void DetermineSituation_FirstPositive()
        {
            ArraysAB arrayExample = new ArraysAB(5);
            arrayExample.a[2] = 3; // Set the third element to a positive value

            string result = arrayExample.DetermineSituation();

            Assert.AreEqual("The first non-zero number is positive.", result);
        }

        [TestMethod]
        public void DetermineSituation_FirstNegative()
        {
            ArraysAB arrayExample = new ArraysAB(5);
            arrayExample.a[1] = -2; // Set the second element to a negative value

            string result = arrayExample.DetermineSituation();

            Assert.AreEqual("The first non-zero number is negative.", result);
        }

     
    }

}
