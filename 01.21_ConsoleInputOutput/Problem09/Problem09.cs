using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Problem09
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double firstNumber = double.Parse(Console.ReadLine());
            for (int counter = 0; counter < firstNumber; counter++)
            {
                double nextNumber = double.Parse(Console.ReadLine());
                Sum = Sum + nextNumber;
            }
            Console.WriteLine(Sum);
        }
    }
}
