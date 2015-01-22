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

            Console.WriteLine("Enter coordinates of the point: ");
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());
            double radius = (Math.Sqrt(((xCoordinate - 1) * (xCoordinate - 1)) + ((yCoordinate - 1)  * (yCoordinate - 1))));
            bool insideCircle = radius <= 1.5;
            bool outRechtangle = (xCoordinate < -1) || (xCoordinate > 5) || (yCoordinate > 1) || (yCoordinate < -1);
            bool solution = insideCircle && outRechtangle;
            if (solution)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
