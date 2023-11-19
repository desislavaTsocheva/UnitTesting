using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;   
        }

        public int Substract(int number1,int number2)
        {
            return number1 - number2;
        }

        public int Multiplay(int number1,int number2)
        {
            return (number1 * number2);
        }
        public int Divide(int number1,int number2)
        {
            if(number2==0)
            {
                throw new DivideByZeroException("devide with zero!");
            }
            return number1 / number2;
        }
        public int Power(int number1, int number2)
        {
            int power= 0;
            if(number2==0)
            {
                power= 1;
            }

            if (number2 > 0)
            {
                for (int i = 0; i < number2; i++)
                {
                    power= number1* number1;
                }
            }
            if (number2 < 0)
            {
                power = 1 / (number1 * number1);
            }
            return power;
        }
    }
}
