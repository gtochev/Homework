using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._13_Methods
{
    class Problem01
    {
        static void AskName()
        {
            Console.Write("Please enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }

        static void Main(string[] args)
        {
            AskName();
        }
    }
}
