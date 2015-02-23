using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MaximumSequence
{
    class Problem04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sequence = 0;
            int counterEqual = 0;
            int counter = 1;

            Console.WriteLine("Enter Array elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    if (counterEqual < counter)
                    {
                        counterEqual = counter;
                        sequence = array[i];
                    }
                }
                else
                {
                    counter = 1;
                }
                counter++;

            }
            for (int i = 0; i < counterEqual; i++)
            {
                Console.Write("{0}, ", sequence);
            }
        }
    }
}
