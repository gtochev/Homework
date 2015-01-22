using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CheckBitAtPosition
{
    class Problem13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int primaryNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int index = int.Parse(Console.ReadLine());
            int mask = 1 << (index);
            mask = primaryNumber & mask;
            mask = mask >> index;
            if (mask == 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
