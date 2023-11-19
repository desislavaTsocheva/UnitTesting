using Calculator;

namespace TestCalculatorMultiplay
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfMultiplayWorksWithPossNums()
        {
            int number1 = 8;
            int number2 = 5;
            Calculate mycal = new Calculate();
            double result = mycal.Multiplay(number1, number2);
            Assert.AreEqual(40, result,"8 * 5 != 40");
        }
        [TestMethod]
        public void TestIfMultiplayWorksWithNegativeNums()
        {
            int number1 = -8;
            int number2 = -5;
            Calculate mycal = new Calculate();
            double result = mycal.Multiplay(number1, number2);
            Assert.AreEqual(40, result, "(-8) * (-5) != 40");
        }
        [TestMethod]
        public void TestIfMultiplayWorksWithPossAndNegNums()
        {
            int number1 = 8;
            int number2 = -5;
            Calculate mycal = new Calculate();
            double result = mycal.Multiplay(number1, number2);
            Assert.AreEqual(-40, result, "8 * (-5) != -40");
        }
        [TestMethod]
        public void TestIfMultiplayWorksWithZeroNums()
        {
            int number1 = 8;
            int number2 = 0;
            Calculate mycal = new Calculate();
            double result = mycal.Multiplay(number1, number2);
            Assert.AreEqual(0, result, "8 * 0 != 0");
        }
    }
}