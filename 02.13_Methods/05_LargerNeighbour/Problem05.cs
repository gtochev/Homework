using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LargerNeighbour
{
    class Problem05
    {
        static void CheckNeighbours(int[] arr, int index)
        {
            if (index > 0 && index < arr.Length - 1)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    Console.WriteLine();
                    Console.WriteLine("The element is bigger than it's neighbours");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The element is smaller or equal to it's neighbours");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The element is at the edge of the array");
            }
        }

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

            Console.Write("Enter element index: ");
            int index = int.Parse(Console.ReadLine());

            CheckNeighbours(arr, index);
        }
    }
}
