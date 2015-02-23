using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompareArrays
{
    class Problem02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arrays lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            Console.WriteLine("Enter First Array elements: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Second Array elements: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool compare = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    compare = false;
                    Console.WriteLine("The arrays are similar - {0}", compare);
                    return;
                }
            }
            Console.WriteLine("The arrays are similar - {0}", compare);
        }
    }
}
