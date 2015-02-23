using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindSunInArr
{
    class Problem10
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

            Console.Write("Enter sum to find: ");
            int sumToFind = int.Parse(Console.ReadLine());
            // WTF
            int sum = 0;
            int biggestSum = 0;


            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i; j < arrayInput.Length; j++)
                {
                    sum += arrayInput[j];
                    maxSumTemp.Add(arrayInput[j]);
                    if (sum == sumToFind)
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
            //Output
            foreach (var item in maxSum)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine();
        }
    }
}
