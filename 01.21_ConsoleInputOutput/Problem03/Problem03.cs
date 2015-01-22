using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter: {0:0.00}", 2 * radius * Math.PI );
            Console.WriteLine("Radius: {0:0.00}", radius * radius * Math.PI);
        }
    }
}
