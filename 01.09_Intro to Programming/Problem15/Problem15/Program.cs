using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Your current age is:");
            Console.Write(2015 - n);
        }
    }
}
