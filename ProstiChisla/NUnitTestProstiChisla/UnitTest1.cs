using NuGet.Frameworks;
using ProstiChisla;

namespace NUnitTestProstiChisla
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase(3)]
        [TestCase(7)]
        [TestCase(5)]
        public void TestWithPrimePossitiveNumbersIfTrue(int number)
        {
            bool result = true;
            ProstiNumbers nums = new ProstiNumbers();
            for (int i = 0; i <3; i++)
            {
                result = nums.Prosti(number);
            }
            Assert.IsTrue(result,"3,7,5 should be prime numbers" );
        }
        [TestCase(-1)]
        public void TestWithNegativeNumbersThrowsEx(int number)
        {
            try
            {
                ProstiNumbers nums = new ProstiNumbers();
                bool result = nums.Prosti(number);  
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
        [TestCase(1)]
        public void TestWith1ThrowsEx(int number)
        {
        ProstiNumbers numbers = new ProstiNumbers();
        bool result=numbers.Prosti(number);
        Assert.IsFalse(result, "1 is not prime number");
        }
        [TestCase(0)]
        public void TestWith0ThrowsEx(int number)
        {
            try
            {
                ProstiNumbers nums = new ProstiNumbers();
                bool result = nums.Prosti(number);
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}