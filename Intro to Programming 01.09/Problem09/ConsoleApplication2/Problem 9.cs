using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2;
            int a = 1;
            while (counter <= 11)
            {
                
                Console.Write(a * counter);
                Console.Write(", ");
                a = -a;
                counter++;
            }
        }
    }
}
