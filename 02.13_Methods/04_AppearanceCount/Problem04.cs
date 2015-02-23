using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AppearanceCount
{
    class Problem04
    {
        static void TimesInArr(int[] entry, int number)
        {
            int counter = 0;
            for (int i = 0; i < entry.Length; i++)
            {
                if (entry[i] == number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
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

            Console.Write("Enter number to look for: ");
            int number = int.Parse(Console.ReadLine());

            //int[] arr = { 1, 2, 3, 2, 4, 2, 5, 2};
            //int number = 2;

            TimesInArr(arr, number);
        }
    }
}
