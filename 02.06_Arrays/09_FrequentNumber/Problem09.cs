using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FrequentNumber
{
    class Problem09
    {
        static void Main(string[] args)
        {
            // Input, filling the array
            Console.Write("Enter array lenght: ");
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[arrLenght];

            Console.WriteLine("Enter Array elements: ");
            
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = int.Parse(Console.ReadLine());
            }

            // Solution
            int counter = 1;
            int timesEncountered = 0;
            int mostCommonNumber = 0;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i; j < arrayInput.Length; j++)
                {
                    if (arrayInput[i] == arrayInput[j])
                    {
                        if (counter > timesEncountered)
                        {
                            mostCommonNumber = arrayInput[i];
                            timesEncountered = counter;
                        }
                        counter++;
                    }
                }
                counter = 1;
            }
            // Output
            Console.WriteLine("{0} ({1} times)", mostCommonNumber, timesEncountered);
        }
    }
}
