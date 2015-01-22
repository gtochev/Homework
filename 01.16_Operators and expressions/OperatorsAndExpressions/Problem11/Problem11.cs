using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Problem11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit number: ");
            int number = int.Parse(Console.ReadLine());
            int firstNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int thirdNumber = (number / 100) % 10;
            int fourthNumber = (number / 1000) % 10;
        }
    }
}
