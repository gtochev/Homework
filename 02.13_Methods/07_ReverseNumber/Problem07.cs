using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ReverseNumber
{
    class Problem07
    {
        static void ReverseNumber(char[] number)
        {
            Array.Reverse(number);

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("{0}", number[i]);
            }
        }
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            bool isNegative = false;

            if (number < 0)
            {
                number *= -1;
                isNegative = true;
            }

            string numberStr = Convert.ToString(number);
            char[] numberArr = new char[numberStr.Length];
            int counter = 0;
            foreach (var item in numberStr)
            {
                numberArr[counter] = item;
                counter++;
            }
            if (isNegative == true)
            {
                Console.Write("-");
                ReverseNumber(numberArr);
            }
            else
            {
                ReverseNumber(numberArr);
            }
        }
    }
}
