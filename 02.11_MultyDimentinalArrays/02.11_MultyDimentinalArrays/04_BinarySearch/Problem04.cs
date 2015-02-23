using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BinarySearch
{
    class Problem04
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter size of array: ");
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] arr = new int[sizeOfArr];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < sizeOfArr; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter integer K: ");
            int k = int.Parse(Console.ReadLine());

            

            //---
            Array.Sort(arr);

            int maxValue = arr[0];
            int temp = maxValue;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxValue = arr[i];
                if (maxValue >= k)
                {
                    break;
                }
                temp = arr[i];
            }

            index = Array.BinarySearch(arr, temp);

            Console.WriteLine(arr[index]);
        }
    }
}
