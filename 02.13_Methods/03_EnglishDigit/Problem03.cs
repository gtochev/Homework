using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnglishDigit
{
    class Problem03
    {
        static void ReturnWord(int lastNumber)
        {
            switch (lastNumber)
            {
                case 0: Console.WriteLine("Zero");break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= -1;
            }
            number = number % 10;

            ReturnWord(number);
        }
    }
}
