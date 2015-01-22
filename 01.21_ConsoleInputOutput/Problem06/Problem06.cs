using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Problem06
    {
        static void Main(string[] args)
        {
            //For ax2 + bx + c = 0, the value of x is given by:
            //x = [ -b ± sqrt(b^2 - 4ac) ] / 2a
            Console.Write("Enter coefficient a: ");
            double aCoefficient = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double bCoefficient = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double cCoefficient = double.Parse(Console.ReadLine());
            double xResultPositive = ((-bCoefficient + Math.Sqrt(bCoefficient * bCoefficient - 4 * aCoefficient * cCoefficient)) / (2 * aCoefficient));
            double xResultNegative = ((-bCoefficient - Math.Sqrt(bCoefficient * bCoefficient - 4 * aCoefficient * cCoefficient)) / (2 * aCoefficient));
            if (xResultPositive != xResultPositive && xResultNegative != xResultNegative)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("X1 = {0}; X2 = {1}", xResultNegative, xResultPositive);
            }
        }
    }
}
