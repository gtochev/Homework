using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08_NumberAsArray
{
    class Problem08
    {
        static List<int> finalOutput = new List<int>();
        static void Main(string[] args)
        {
            // Defining and filling both number arrays with digits, Backwards!
            Console.Write("Enter first number size: ");
            int firstNumSize = int.Parse(Console.ReadLine());
            int[] firstArr = new int[firstNumSize];
            Console.WriteLine("Enter each number digit on different line: ");


            for (int i = firstNumSize; i >= 0; i--)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter second number size: ");
            int secondNumSize = int.Parse(Console.ReadLine());
            int[] secondArr = new int[secondNumSize];

            for (int i = secondNumSize; i >= 0; i--)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            // Final sum will be in the following arr
            
            //
            if (firstArr.Length < secondArr.Length)
            {
                AddArrAsNumber(firstArr, secondArr);
            }
            else
            {
                AddArrAsNumber(secondArr, firstArr);
            }
            // Printing 
            foreach (var item in finalOutput)
            {
                Console.WriteLine("{0} ", item);
            }
        }

        static void AddArrAsNumber(int[] arrOne, int[] arrTwo)
        {
            bool overTen = false;
            int sum = 0;
            for (int i = 0; i < arrOne.Length; i++)
            {
                
                sum = arrOne[i] + arrTwo[i];
                finalOutput.Add(sum % 10);

                if (sum > 10)
                {
                    overTen = true;
                }
                sum = 0;
                if (overTen)
                {
                    sum += 1;
                    overTen = false;
                }
            }

            for (int i = arrOne.Length; i < arrTwo.Length; i++)
            {
                sum += arrTwo[i];
                finalOutput.Add(sum % 10);
                if (sum > 10)
                {
                    overTen = true;
                }
                sum = 0;
                if (overTen)
                {
                    sum += 1;
                    overTen = false;
                }

            }
            if (sum == 1)
            {
                finalOutput.Add(1);
            }
        }
    }
}
