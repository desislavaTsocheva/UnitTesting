using Calculator;

namespace TestPower
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfPowerWorksProperlyWithPossNums()
        {
            int number1 = 2;
            int power = 3;
            Calculate c1 = new Calculate();
            double result = c1.Power(number1,power);
            Assert.AreEqual(8,result, "2 on power 3 != 8 ");
        }
    }
}