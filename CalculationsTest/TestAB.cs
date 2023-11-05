using Pract.Pract3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pract.Pract3.UnitTests
{

    [TestClass]
    public class CalculationsABTests
    {
        [TestMethod]
        public void Count_WithValidRange_CalculatesCorrectly()
        {
            // Arrange
            double a = 10;
            double b = 30;
            CalculationsAB calculations = new CalculationsAB(a, b); // (14, 20, 26)

            // Act
            int result = calculations.Count();

            // Assert 
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Count_WithNegativeRange_ReturnsZero()
        {
            // Arrange
            double a = -5;
            double b = -1;
            CalculationsAB calculations = new CalculationsAB(a, b);

            // Act
            int result = calculations.Count();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Count_WithSingleValueInRange_ReturnsZeroOrOne()
        {
            // Arrange
            double a = 5;
            double b = 5;
            CalculationsAB calculations = new CalculationsAB(a, b);

            // Act
            int result = calculations.Count();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Count_WithNoValidNumbersInRange_ReturnsZero()
        {
            // Arrange
            double a = 4;
            double b = 5;
            CalculationsAB calculations = new CalculationsAB(a, b);

            // Act
            int result = calculations.Count();

            // Assert
            Assert.AreEqual(0, result);
        }

       
    }
}
