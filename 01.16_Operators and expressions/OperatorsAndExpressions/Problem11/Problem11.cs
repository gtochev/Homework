using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Problem11
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int calculator = 1 << 3;
            int operation = number & calculator;
            operation = operation >> 3;
            Console.WriteLine("bit#3: " + operation);
        }
    }
}
