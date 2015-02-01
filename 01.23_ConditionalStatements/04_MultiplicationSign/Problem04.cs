using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MultiplicationSign
{
    class Problem04
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("0");
            }
            else if ((firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0))
            {
                Console.WriteLine("-");
            }
            else if (((firstNumber < 0 && secondNumber < 0) || (firstNumber > 0 && secondNumber > 0)))
            {
                Console.WriteLine("+");
            }
        }
    }
}
