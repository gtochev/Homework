using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PlayWith
{
    class Problem09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter int: ");
                    int integerEntry = int.Parse(Console.ReadLine());
                    Console.WriteLine(integerEntry + 1);
                    break;
                case "2":
                    Console.WriteLine("Enter double: ");
                    double doubleEntry = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleEntry + 1);
                    break;
                case "3":
                    Console.WriteLine("Enter string: ");
                    string stringEntry = Console.ReadLine();
                    Console.WriteLine(stringEntry + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
