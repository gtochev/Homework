using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2013_02_Female_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int sumEven = 0;
            int sumOdd = 0;
            string input = Console.ReadLine();
            int[] ednomerna = new int[input.Length];

            // Assigning the numbers to a Massive
            for (int i = 0; i < input.Length; i++)
            {
                ednomerna[i] = Convert.ToInt16(input[i]);
            }
            // Finding sum odd and sum even
            for (int j = 0; j < input.Length; j++)
            {
                if (ednomerna[j] % 2 == 0)
                {
                    sumEven += (ednomerna[j] - 48);
                }
                else
                {
                    sumOdd += (ednomerna[j] - 48);
                }
                
            }

            // Output

            if (sumEven > sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            if (sumOdd > sumEven)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("straight {0}", sumEven);
            }
        }
    }
}
