using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2013__Evening_2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long sum = 0;
            long result = 0;

            switch (secondNumber)
            {
                case 2: result = firstNumber % thirdNumber; break;
                case 4: result = firstNumber + thirdNumber; break;
                case 8: result = firstNumber * thirdNumber; break;
                default:
                    break;
            }
            if (result % 4 == 0)
            {
                sum = result / 4;
            }
            else
            {
                sum = result % 4;
            }
            Console.WriteLine(sum);
            Console.WriteLine(result);

        }
    }
}
