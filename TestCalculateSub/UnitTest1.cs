using Calculator;

namespace TestCalculateSub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfSubWorksWithNegativeNumbers()
        {
            //Arrange
            int number1 = -80;
            int number2 = -30;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Substract(number1, number2);
            //Assert
            Assert.AreEqual(-50, result," 80- (-30) != -50");
        }
        [TestMethod]
        public void TestIfSubWorksWithPossitiveNumbers()
        {
            //Arrange
            int number1 = 80;
            int number2 = 30;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Substract(number1, number2);
            //Assert
            Assert.AreEqual(50, result, " 80-30) != 50");
        }
        [TestMethod]
        public void TestIfSubWorksWithPossitiveAndNegativeNumbers()
        {
            //Arrange
            int number1 = -80;
            int number2 = +30;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Substract(number1, number2);
            //Assert
            Assert.AreEqual(-110, result, " -80- (+30) != -110");
        }
    }
}