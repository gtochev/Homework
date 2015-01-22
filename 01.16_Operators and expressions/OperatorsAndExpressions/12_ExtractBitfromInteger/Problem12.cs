using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExtractBitfromInteger
{
    class Problem12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int primaryNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            int mask = 1 << index;
            mask = primaryNumber & mask;
            mask = mask >> index;
            Console.WriteLine(mask);
        }
    }
}
