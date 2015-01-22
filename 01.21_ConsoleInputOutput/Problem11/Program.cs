using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber <= secondNumber)
            {
                for (int result = firstNumber; result < secondNumber; result++)
                {
                    if (result % 5 == 0)
                    {
                        Console.Write(result + " ");
                    }
                }
            }
            else
            {
                for (int result = secondNumber; result < firstNumber; result++)
                {
                    if (result % 5 == 0)
                    {
                        Console.Write(result + " ");
                    }
                }

            }
        }
    }
}
