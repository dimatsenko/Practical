
using Pract.Pract3;

namespace CalculationsTest
{
    [TestClass]
    public class TestABC
    {
        [TestMethod]
        public void Test_NoMultiplesOf27_ReturnsZero()
        {
            // Arrange
            int a = 10;
            int b = 15;
            int c = 20;
            var calculations = new CalculationsABC(a, b, c);

            // Act
            int result = calculations.D();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_OneMultipleOf27_ReturnsOne()
        {
            // Arrange
            int a = 27;
            int b = 15;
            int c = 20;
            var calculations = new CalculationsABC(a, b, c);

            // Act
            int result = calculations.D();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_AllMultiplesOf27_ReturnsThree()
        {
            // Arrange
            int a = 27;
            int b = 54;
            int c = 81;
            var calculations = new CalculationsABC(a, b, c);

            // Act
            int result = calculations.D();

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}