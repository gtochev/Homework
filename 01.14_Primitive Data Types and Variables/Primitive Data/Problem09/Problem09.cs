using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Problem09
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The first value of 'a' is: " + a);
            Console.WriteLine("The first value of 'b' is: " + b);
            int interim = b;
            b = a;
            a = interim;
            Console.WriteLine("The new value of 'a' is: " + a);
            Console.WriteLine("The new value of 'b' is: " + b);
        }
    }
}
