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
            Console.WriteLine("Enter side A, side B and height of the trapezoid: ");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the rectangle is: " + (((sideA + sideB) * height) / 2));
        }
    }
}
