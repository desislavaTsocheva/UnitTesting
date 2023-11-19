using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiChisla
{
    public class ProstiNumbers
    {
        public bool Prosti(int number1)
        {
            bool result= false;
            for (int delitel = 2; delitel < number1-1; delitel++)
            {
                if (number1 <= 0)
                throw new ArgumentException("Must be greater than zero");

                if (number1 == 1)
                result= false; 

                if (number1 % delitel == 0)
                {
                    result = false;
                    break;
                }
                else 
                {
                    result = true; 
                }
            }
            return result;
        }
    }
}
