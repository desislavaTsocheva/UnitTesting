using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNUnit
{
    public class Calculators
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiplay(int number1, int number2)
        {
            return (number1 * number2);
        }
        public int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("devide with zero!");
            }
            return number1 / number2;
        }
    }
}
