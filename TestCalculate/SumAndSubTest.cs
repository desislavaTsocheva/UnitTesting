using Calculator;

namespace TestCalculate
{
    [TestClass]
    public class SumAndSubTest
    {
        [TestMethod]
        public void IfSumWorksProperlyWithPossitiveNumbers()
        {
            //Arrange
            int number1 = 45;
            int number2 = 56;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Sum(number1, number2);
            //Assert
            Assert.AreEqual(101, result, "45 + 56 != 101");
        }
        [TestMethod]
        public void IfSumWorksWithNegativeNums()
        {
            //Arrange
            int number1 = -45;
            int number2 = -56;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Sum(number1, number2);
            //Assert
            Assert.AreEqual(-101, result, "-45 + (-56) != -101");
        }
        [TestMethod]
        public void IfSumWorksWithNegativeAndPossitiveNums()
        {
            //Arrange
            int number1 = -45;
            int number2 = +56;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Sum(number1, number2);
            //Assert
            Assert.AreEqual(11, result, "-45 + 56) != 11");
        }
        [TestMethod]
        public void IfSumWorksWithZeroAndPossitiveNums()
        {
            //Arrange
            int number1 = 0;
            int number2 = 56;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Sum(number1, number2);
            //Assert
            Assert.AreEqual(56, result, "0 + 56) != 56");
        }
        [TestMethod]
        public void IfSumWorksWithZeroAndNegativeNums()
        {
            //Arrange
            int number1 = 0;
            int number2 = -56;
            Calculate myCalculator = new Calculate();
            //Act
            double result = myCalculator.Sum(number1, number2);
            //Assert
            Assert.AreEqual(-56, result, "0 + 56) != -56");
        }
    }
}