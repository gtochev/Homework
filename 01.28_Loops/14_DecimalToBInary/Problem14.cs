using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DecimalToBInary
{
    class Problem14
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int[] matrix = new int[64];
            long calculation = number;
            long position = 63;

            while (position >= 0)
            {
                if (calculation % 2 == 1)
                {
                    matrix[position] = 1;
                }
                else
	            {
                    matrix[position] = 0;
	            }
                calculation /= 2;
                position--;
            }

            position = 0;
            while (matrix[position] == 0)
            {
                position++;
            }

            for (long i = position; i < matrix.Length; i++)
            {
                Console.Write(matrix[i]);
            }
        }
    }
}
