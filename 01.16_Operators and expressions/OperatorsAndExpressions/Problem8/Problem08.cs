using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Problem08
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter whole number: ");
            int number = int.Parse(Console.ReadLine());
            int leftover;
            for (int counter = 2; counter <= number; counter++)
            {
                leftover = number % counter;
                if (leftover == 0 && counter == number)
                {
                    Console.WriteLine("The number IS prime!");
                    break;
                }
                if (leftover == 0 && counter != number)
                {
                    Console.WriteLine("The number is NOT prime!");
                    break;
                }
            }
        }
    }
}
