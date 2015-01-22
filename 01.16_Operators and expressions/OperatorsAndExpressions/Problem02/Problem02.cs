using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight: ");
            double earthWeight = double.Parse(Console.ReadLine());
            double moonWeight = earthWeight * 0.17;
            Console.WriteLine("Moon weight is: " + moonWeight);
        }
    }
}
