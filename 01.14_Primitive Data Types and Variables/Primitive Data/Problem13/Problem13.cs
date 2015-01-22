using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class Problem13
    {
        static void Main(string[] args)
        {
            double firstFloat = 0.1d;
            double secondFloat = 0.1d;
            Console.Write("Enter first Number: ");
            firstFloat = double.Parse(Console.ReadLine());
            Console.Write("Enter second Number: ");
            secondFloat = double.Parse(Console.ReadLine());
            //Defining the precision
            double precision = 0.000001d;
            //Comparing values
            bool comparison = (Math.Abs(firstFloat - secondFloat) <= precision);
            Console.WriteLine(comparison);
        }
    }
}
