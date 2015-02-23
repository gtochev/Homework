using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SortStringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int arrLenght = int.Parse(Console.ReadLine());
            string[] arr = new string[arrLenght];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            // Ot Ivaylo :)
            arr = arr.OrderBy(t => t.Length).ToArray();
        }
    }
}
