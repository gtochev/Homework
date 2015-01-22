using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Problem06
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit number: ");
            int number = int.Parse(Console.ReadLine());
            int firstNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int thirdNumber = (number / 100) % 10;
            int fourthNumber = (number / 1000) % 10;
            Console.WriteLine("The sum of the digits is: " + (firstNumber + secondNumber + thirdNumber + fourthNumber));
            Console.WriteLine("The number in reverse order is: " + firstNumber + secondNumber + thirdNumber + fourthNumber);
            Console.WriteLine("Last digit in first position: " + firstNumber + fourthNumber + thirdNumber + secondNumber);
            Console.WriteLine("Second and third digits exchanged: " + fourthNumber + secondNumber + thirdNumber + firstNumber);
        }
    }
}
