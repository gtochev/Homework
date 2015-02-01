using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumbersNotDivisibleBy3And7
{
    class Problem02
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
