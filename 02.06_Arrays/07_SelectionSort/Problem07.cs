using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SelectionSort
{
    class Problem07
    {
        static void Main(string[] args)
        {
            // Input, filling the array
            Console.Write("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[n];
            List<int> spisuk = new List<int>();
            

            Console.WriteLine("Enter Array elements: ");
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = int.Parse(Console.ReadLine());
            }

            // Finding the max number
            int maxInt = arrayInput[0];
            for (int j = 1; j < n; j++)
            {
                if (maxInt <= arrayInput[j])
                {
                    maxInt = arrayInput[j];
                }
            }

            //Logic
            int tmpMin = arrayInput[0];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tmpMin >= arrayInput[j])
                    {
                        tmpMin = arrayInput[j];
                        counter = j;
                    }
                }
                arrayInput[counter] = maxInt;
                spisuk.Add(tmpMin);
                tmpMin = maxInt;
            }

            // Output
            for (int i = 0; i < arrayInput.Length; i++)
            {
                Console.Write("{0} ", spisuk[i]);
            }
            Console.WriteLine();
        }
    }
}
