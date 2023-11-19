using Calculator;

namespace TestDivide
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfDivideWorksProperlyWithPossNums()
        {
            //Arrange
            int number1 = 80;
            int number2 = 20;
            Calculate mycal = new Calculate();
            //Act
            double result=mycal.Divide(number1, number2);
            //Assert
            Assert.AreEqual(4, result, "80 / 20 != 4");
        }
        [TestMethod]
        public void TestIfDivideWorksProperlyWithNegativeNums()
        {
            //Arrange
            int number1 = -80;
            int number2 = -20;
            Calculate mycal = new Calculate();
            //Act
            double result = mycal.Divide(number1, number2);
            //Assert
            Assert.AreEqual(4, result, "(-80) / (-20) != 4");
        }
        [TestMethod]
        public void TestIfDivideWorksProperlyWithPossAndNegNums()
        {
            //Arrange
            int number1 = 80;
            int number2 = -20;
            Calculate mycal = new Calculate();
            //Act
            double result = mycal.Divide(number1, number2);
            //Assert
            Assert.AreEqual(-4, result, "80 / (-20) != -4");
        }
    }
}