using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Problem12
    {
        static void Main(string[] args)
        {
            int? integerVar = null;
            double? doubleVar = null;
            Console.WriteLine("-----Null Variables-----");
            Console.WriteLine("Current value of integerVar is: " + integerVar + "\n" + "Current value of doubleVar is: " + doubleVar);
            Console.WriteLine("-----Trying to add number to Null Variables-----");
            integerVar = integerVar + 10;
            doubleVar = doubleVar + 15;
            Console.WriteLine("Current value of integerVar is: " + integerVar + "\n" + "Current value of doubleVar is: " + doubleVar);
            Console.WriteLine("-----Assigning valute to Null Variables-----");
            int first = 2;
            integerVar = first;
            int second = 3;
            doubleVar = second;
            Console.WriteLine("Current value of integerVar is: " + integerVar + "\n" + "Current value of doubleVar is: " + doubleVar);
        }
    }
}
