using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompareCharArrays
{
    class Problem03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arrays lenght: ");
            int n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            char[] secondArray = new char[n];

            Console.WriteLine("Enter First Array elements: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Second Array elements: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
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
