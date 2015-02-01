using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_NumbersAsWords
{
    class Program
    {
        static int number = 0;
        static int numberDesetici = 0;
        static int numberStotici = 0;
        static string counter = string.Empty;

        static void CountingEdinici()
        {
            switch (number)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 0: Console.WriteLine(""); break;
                default: Console.WriteLine("Not a number"); break;
            }
        }

        static void CountingDesetici()
        {
            numberDesetici = number / 10;
            switch (numberDesetici)
            {
                case 1: number = number % 10;
                    switch (number)
                    {
                        case 1: Console.WriteLine("Eleven"); break;
                        case 2: Console.WriteLine("Twelve"); break;
                        case 3: Console.WriteLine("Thirteen"); break;
                        case 4: Console.WriteLine("Fourteen"); break;
                        case 5: Console.WriteLine("Fifteen"); break;
                        case 6: Console.WriteLine("Sixteen"); break;
                        case 7: Console.WriteLine("Seventeen"); break;
                        case 8: Console.WriteLine("Eighteen"); break;
                        case 9: Console.WriteLine("Nineteen"); break;
                        case 0: Console.WriteLine("Ten"); break;
                        default: Console.WriteLine("Not a number"); break;
                    } 
                    break;
                case 2: Console.Write("Twenty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 3: Console.Write("Thirty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 4: Console.Write("Fourty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 5: Console.Write("Fifty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 6: Console.Write("Sixty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 7: Console.Write("Seventy ");
                    number = number % 10;
                    CountingEdinici();break;
                case 8: Console.Write("Eighty ");
                    number = number % 10;
                    CountingEdinici();break;
                case 9: Console.Write("Ninety ");
                    number = number % 10;
                    CountingEdinici();break;
                default: Console.WriteLine("Not a number");
                    CountingEdinici();break;
            }
        }

        static void CountingStotici()
        {
            numberStotici = number / 100;
            switch (numberStotici)
            {
                case 1: Console.Write("One Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 2: Console.Write("Two Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 3: Console.Write("Three Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 4: Console.Write("Four Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 5: Console.Write("Five Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 6: Console.Write("Six Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 7: Console.Write("Seven Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 8: Console.Write("Eight Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 9: Console.Write("Nine Hundred and ");
                    number = number % 100;
                    CountingDesetici();break;
                case 0: Console.Write("");
                    CountingDesetici();break;
                default: Console.Write("Not a number"); break;
            }
        }

        static void Main(string[] args)
        {
            number = int.Parse(Console.ReadLine());
            counter = Convert.ToString(number);
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }

            if (counter.Length == 1)
            {
                CountingEdinici();
            }
            else if (counter.Length == 2)
            {
                CountingDesetici();
            }
            else if (counter.Length == 3)
            {
                CountingStotici();
            }
        }
    }
}
