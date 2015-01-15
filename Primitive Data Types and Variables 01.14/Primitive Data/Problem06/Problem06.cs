using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Problem06
    {
        static void Main(string[] args)
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object concatenation = firstVar + " " + secondVar;
            string thirdVar = (string)concatenation;
            Console.WriteLine(thirdVar);
        }
    }
}
