using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinMaxSumAndAverageN
{
    class Problem03
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal min = 0;
            decimal[] matrix = new decimal[number];
            decimal max = 0;
            decimal sum = 0;
            decimal avg = 0;

            // Input
            for (int i = 0; i < number; i++)
            {
                decimal entry = decimal.Parse(Console.ReadLine());
                matrix[i] = entry;

            }
            min = matrix[0];
            max = matrix[0];
            // Finding the Min
            for (int i = 0; i < matrix.Length; i++)
            {
                if (min >= matrix[i])
                {
                    min = matrix[i];
                }
            }

            // Finding Max
            for (int i = 0; i < matrix.Length; i++)
            {
                if (max <= matrix[i])
                {
                    max = matrix[i];
                }
            }

            // Finding the sum
            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i];
            }

            // Finding average
            for (int i = 0; i < matrix.Length; i++)
            {
                avg += matrix[i];
            }
            avg = avg / matrix.Length;

            // Output
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
        }
    }
}
