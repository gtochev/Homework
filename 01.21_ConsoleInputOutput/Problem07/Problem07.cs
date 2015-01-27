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
            string[] numbers = Console.ReadLine().Split(' ');
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine(sum);

        }
    }
}
