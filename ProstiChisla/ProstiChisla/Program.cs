using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiChisla
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            ProstiNumbers nums = new ProstiNumbers();
            //Act
            bool result=nums.Prosti(number);
            //Assert
            Console.WriteLine(result);
        }
    }
}
