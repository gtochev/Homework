using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxKSum
{
    class Problem06
    {
        static void Main(string[] args)
        {
            // Input and filling the array
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (K has to be smaller than N): ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter {0} numbers:", n);
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // 
            Array.Sort(arr);

            for (int i = n - k; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

        }
    }
}
