using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OddAndEvenProduct
{
    class Problem10
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] matrix = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int odd = 1;
            int even = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 2 == 0) odd *= matrix[i];
                else even *= matrix[i];
            }

            if (odd == even)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
