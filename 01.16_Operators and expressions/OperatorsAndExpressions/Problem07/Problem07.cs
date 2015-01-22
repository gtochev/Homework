using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Problem07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of the point: ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double radius = Math.Sqrt((firstNumber * firstNumber) + (secondNumber * secondNumber));
            Console.WriteLine((radius) <= 2 ? "The point is in the circle!" : "The point is outside the circle!");
        }
    }
}
