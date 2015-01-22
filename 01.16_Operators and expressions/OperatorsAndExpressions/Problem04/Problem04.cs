using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Problem04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Width and Height of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the rectangle is: " + ((width + height) * 2));
            Console.WriteLine("The area of the rectangle is: " + (width * height));
        }
    }
}
