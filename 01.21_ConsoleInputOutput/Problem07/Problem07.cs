using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Problem07
    {
        static void Main(string[] args)
        {
            int place = 5;
            int number = 35;
            int mask = 1 << place;
            int andMask = number & mask;
            int bitPlace = andMask >> place;
            Console.WriteLine(bitPlace);

        }
    }
}
