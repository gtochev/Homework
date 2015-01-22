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
            Console.Write("Enter whole number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 & number % 7 == 0)
	{
		 Console.WriteLine("The number CAN be divided without remainder by 7 and 5!");
	}
            else
            {
                Console.WriteLine("The number CAN'T be divided without remainder by 7 and 5!");
            }
            
        }
    }
}
