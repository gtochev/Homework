using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Problem14
    {
        static void Main(string[] args)
        {
            char asciSymbol = '\u0001';
            for (int counter = 0; counter < 255; counter++)
            {
                Console.Write(" " + asciSymbol);
                asciSymbol++;
            }
        }
    }
}
