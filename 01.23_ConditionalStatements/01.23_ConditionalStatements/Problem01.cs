using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._23_ConditionalStatements
{
    class Problem01
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double buffer = 0;
            
            if (firstNumber > secondNumber)
            {
                buffer = secondNumber;
                secondNumber = firstNumber;
                firstNumber = buffer;
                Console.WriteLine(firstNumber + " " + secondNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + " " + secondNumber);
            }
        }
    }
}
