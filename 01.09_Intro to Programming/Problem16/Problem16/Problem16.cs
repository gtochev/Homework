using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Problem16
    {
        static void Main(string[] args)
        {
            int counter = 2;
            int a = 1;
            int n = 0;
            while (counter <= 1001)
            {
                n = counter;
                Console.Write(a * n);
                Console.Write(", ");
                a = -a;
                counter++;
            }
        }
    }
}
