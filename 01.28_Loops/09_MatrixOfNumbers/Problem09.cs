using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MatrixOfNumbers
{
    class Problem09
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int secondLoop = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(secondLoop);
                    secondLoop++;
                }
                secondLoop = i + 1;
                Console.WriteLine();
            }
        }
    }
}
