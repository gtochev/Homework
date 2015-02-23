using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GetLargestNumber
{
    class Problem02
    {
        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers, each on new line:");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                GetMax(numberTwo, numberThree);
            }

        }
    }
}
