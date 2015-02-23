using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MaxIncreasingSequence
{
    class Problem05
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayPrime = new int[n];
            int[] arrayForPrint = new int[n];
            int counterIncr = 0;
            int counter = 2;
            // Filling the array
            Console.WriteLine("Enter Array elements: ");
            for (int i = 0; i < arrayPrime.Length; i++)
            {
                arrayPrime[i] = int.Parse(Console.ReadLine());
            }
            // Logic
            for (int i = 1; i < arrayPrime.Length; i++)
            {
                if ((arrayPrime[i - 1] <= arrayPrime[i]) && (counterIncr < counter))
                {
                    counterIncr = counter;
                    for (int j = 0; j < counterIncr; j++)
                    {
                        arrayForPrint[j] = arrayPrime[i - counterIncr + j + 1];
                    }
                }
                else if (arrayPrime[i - 1] > arrayPrime[i])
                {
                    counter = 1;
                }
                counter++;
            }
            // Output
            Console.WriteLine("The maximum increasing sequence in the array is:");
            for (int i = 0; i < counterIncr; i++)
            {
                Console.Write("{0}, ", arrayForPrint[i]);
            }
            Console.WriteLine();
        }
    }
}
