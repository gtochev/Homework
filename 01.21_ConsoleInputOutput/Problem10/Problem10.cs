using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Problem10
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fibonachiOne = - 1;
            int fibonachiTwo = 1;
            for (int counter = 0; counter < number; counter++)
            {
                int fibonachi = fibonachiOne + fibonachiTwo;
                Console.Write(fibonachi + " ");
                fibonachiOne = fibonachiTwo;
                fibonachiTwo = fibonachi;
            }
        }
    }
}
