using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MaxSUm
{
    class Problem08
    {
        static void Main(string[] args)
        {
            // Input, filling the array
            Console.Write("Enter array lenght: ");
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[arrLenght];
            List<int> maxSumTemp = new List<int>();
            List<int> maxSum = new List<int>();


            Console.WriteLine("Enter Array elements: ");
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = int.Parse(Console.ReadLine());
            }

            // WTF
            int sum = 0;
            int biggestSum = 0;


            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i; j < arrayInput.Length; j++)
                {
                    sum += arrayInput[j];
                    maxSumTemp.Add(arrayInput[j]);
                    if (sum > biggestSum)
                    {
                        maxSum.Clear();
                        foreach (var item in maxSumTemp)
                        {
                            maxSum.Add(item);
                        }
                        biggestSum = sum;
                    }
                }
                sum = 0;
                maxSumTemp.Clear();
            }

            // Biggest sum
            Console.WriteLine("Biggest sum is {0}", biggestSum);
            // Printing list of max sum
            Console.WriteLine("The sequence of maximum sum in the array is:");
            foreach (var item in maxSum)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
