using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CheckForPlayCard
{
    class Problem03
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();

            switch (character)
            {
                case "2": Console.WriteLine("Yes"); break;
                case "3": Console.WriteLine("Yes"); break;
                case "4": Console.WriteLine("Yes"); break;
                case "5": Console.WriteLine("Yes"); break;
                case "6": Console.WriteLine("Yes"); break;
                case "7": Console.WriteLine("Yes"); break;
                case "8": Console.WriteLine("Yes"); break;
                case "9": Console.WriteLine("Yes"); break;
                case "10": Console.WriteLine("Yes"); break;
                case "J": Console.WriteLine("Yes"); break;
                case "Q": Console.WriteLine("Yes"); break;
                case "K": Console.WriteLine("Yes"); break;
                case "A": Console.WriteLine("Yes"); break;
                default: Console.WriteLine("No"); break;
            }
        }
    }
}
