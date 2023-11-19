using CalculatorNUnit;

namespace TestNUnitCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,3)]
        [TestCase(-2,3)]
        [TestCase(2,-3)]
        [TestCase(-2,-3)]
        [TestCase(0,3)]
        public void If_Sum_Works_Properly(int number1,int number2)
        {
            double result=0;
            Calculators  c1 = new Calculators();
            for (int i = 0; i < 5; i++)
            {
                result = c1.Sum(number1, number2);
                Assert.AreEqual(number1+number2, result);
            }
        }
        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, 3)]
        public void If_Sub_Works_Properly(int number1, int number2)
        {
            double result = 0;
            Calculators c1 = new Calculators();
            for (int i = 0; i < 5; i++)
            {
                result = c1.Substract(number1, number2);
                Assert.AreEqual(number1 - number2, result);
            }
        }
        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, 3)]
        public void If_Multiplay_Works_Properly(int number1, int number2)
        {
            double result = 0;
            Calculators c1 = new Calculators();
            for (int i = 0; i < 5; i++)
            {
                result = c1.Multiplay(number1, number2);
                Assert.AreEqual(number1 * number2, result);
            }
        }
        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, 3)]
        public void If_Divide_Works_Properly(int number1, int number2)
        {
            double result = 0;
            Calculators c1 = new Calculators();
            for (int i = 0; i < 5; i++)
            {
                result = c1.Divide(number1, number2);
                Assert.AreEqual(number1 / number2, result);
            }
        }

    }
}