using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BinarySearch
{
    class Problem11
    {
        static void Main(string[] args)
        {
            // Input, filling the array
            Console.Write("Enter array lenght: ");
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[arrLenght];
            int index = arrayInput.Length / 2;


            Console.WriteLine("Enter SORTED from low to high Array elements: ");
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element whose index we need to find: ");
            int number = int.Parse(Console.ReadLine());

            // WTF
            int numberCompare = arrayInput[index];
            while (arrayInput[index] != number)
            {
                if (arrayInput[index] > number)
                {
                    index /= 2;
                }
                else if (arrayInput[index] < number)
	            {
                    index = index + index / 2;
	            }
                else if (arrayInput[index] == number)
                {
                    break;
                }
            }

            // Output
            Console.WriteLine("The indes of the element we look for is: {0}", index);
        }
    }
}
