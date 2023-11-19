using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opCode = string.Empty;
            long result = 0;
            do
            {
                opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');
                int operandOne = 0;
                int operandTwo = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            result = operandOne++;
                            break;
                        }
                    case "DEC":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            result = operandOne--;
                            break;
                        }
                    case "ADD":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            operandTwo = int.Parse(codeArgs[2]);
                            result =(operandOne * operandTwo);
                            break;
                        }
                }
            }
            while (opCode != "end");
            Console.WriteLine(result);
        }
    }
}
