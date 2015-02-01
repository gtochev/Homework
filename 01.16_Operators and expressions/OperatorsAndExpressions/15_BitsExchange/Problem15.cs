using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BitsExchange
{
    class Problem15
    {
        static void Main(string[] args)
        {
            long firstBit = int.Parse(Console.ReadLine());

            firstBit ^= 2 << 1;
            firstBit |= 23 << 1;
            firstBit ^= 4 << 1;
            firstBit |= 25 << 1;

            /*
            // 3 and 24 replacement
            if (((firstBit >> 2 & 1) == 0) && ((firstBit >> 23 & 1) == 1))
            {
                firstBit |= 2 << 1;
                firstBit ^= 23 << 1;
            }
            else if(((firstBit >> 2 & 1) == 1) && ((firstBit >> 23 & 1) == 0))
            {
                firstBit ^= 2 << 1;
                firstBit |= 23 << 1;
            }
            // 4 and 25 replacement 
            if (((firstBit >> 3 & 1) == 1) && ((firstBit >> 24 & 1) == 0))
            {
                firstBit ^= 3 << 1;
                firstBit |= 24 << 1;
            }
            else if (((firstBit >> 3 & 1) == 0) && ((firstBit >> 24 & 1) == 1))
            {
                firstBit |= 3 << 1;
                firstBit ^= 24 << 1;
            }
            // 5 and 26 replacement
            if (((firstBit >> 4 & 1) == 0) && ((firstBit >> 25 & 1) == 1))
            {
                firstBit |= 4 << 1;
                firstBit ^= 25 << 1;
            }
            else if (((firstBit >> 4 & 1) == 1) && ((firstBit >> 25 & 1) == 0))
	        {
		        firstBit ^= 4 << 1;
                firstBit |= 25 <<1;
	        }*/
            Console.WriteLine(firstBit);
            Console.WriteLine();
        }
    }
}
