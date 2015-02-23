using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].

namespace _10_NFactorial
{
    class Problem10
    {
        static BigInteger nFactorial = 1;

        static BigInteger Factorial(int number)
        {
            nFactorial *= number;
            return nFactorial;
        }

        static void Main(string[] args)
        {

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(Factorial(i));
            }
        }
    }
}
