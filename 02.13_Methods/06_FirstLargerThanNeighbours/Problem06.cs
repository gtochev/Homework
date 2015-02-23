using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FirstLargerThanNeighbours
{
    class Problem06
    {
        static bool check = false;
        // Method from previous problem (Modified)
        static void CheckNeighbours(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                Console.WriteLine();
                Console.WriteLine(-1);
                check = true;
                return;
            }
            if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
            {
                Console.WriteLine();
                Console.WriteLine("The index of the first element bigger than it's neighbours is: {0}", index);
                check = true;
            }
        }
        // Method
        static void LargerNeighbour(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                CheckNeighbours(arr, i);
                if (check == true)
                {
                    return;
                }
            }
        }

        // Main
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];
            Console.WriteLine("Please enter array elements on separate lines:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            LargerNeighbour(arr);
        }
    }
}
