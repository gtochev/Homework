using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _12._06._2011_02_Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            BigInteger nthNumber = 0;
            
            BigInteger  mediumOne = 0;

            if (position == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else if (position == 2)
            {
                Console.WriteLine(secondNumber);
            }
            else if (position == 3)
            {
                Console.WriteLine(thirdNumber);
            }
            for (int i = 4; i < position + 1; i++)
            {
                nthNumber = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = nthNumber;
            }
            Console.WriteLine(nthNumber);
        }
    }
}
