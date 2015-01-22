using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ModifyBitAtGivenPosition
{
    class Problem14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number 'n': ");
            int primaryNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter bit value 'v': ");
            int primaryBit = int.Parse(Console.ReadLine());
            Console.Write("Enter position 'p': ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            mask = primaryNumber & mask;
            mask = mask >> position;

            if ((mask == 1 && primaryBit == 1) || (mask == 0 && primaryBit == 0))
            {
                Console.WriteLine(Convert.ToString(primaryNumber, 2).PadLeft(16, '0'));
            }
            else
	        {
	        	int newMask = 1 << position;
                newMask = primaryNumber ^ newMask;
                Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(16, '0'));
	        }
        }
    }
}
