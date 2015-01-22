using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class Problem01
    {
        static void Main(string[] args)
        {
            Console.Write("Enter whole number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == -+1 ? "The number is odd!" : "The number is even!");
        }
    }
}
