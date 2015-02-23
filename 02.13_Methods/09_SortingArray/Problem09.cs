using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SortingArray
{
    class Problem09
    {
        static int index = 0;
        // Max element in portion of the array
        static int SortingMethod(int beginning, int end, int[] arr)
        {
            int biggest = arr[0];
            for (int i = beginning; i < end; i++)
            {
                if (biggest < arr[i])
                {
                    biggest = arr[i];
                    index = i;
                }
            }
            return biggest;
            
        }
        // Sorting the array
        static List<int> SortingArray(int[] arrLenght)
            {
                List<int> tempList = new List<int>();
                List<int> finalList = new List<int>();
                int biggest = arrLenght[0];
                
                // filling tempList with the array
                foreach (var item in arrLenght)
                {
                    tempList.Add(item);
                }
                
                // Sorting
                for (int i = 0; i < arrLenght.Length; i++)
                {

                    
                    biggest = SortingMethod(0, i, arrLenght);
                    tempList.RemoveAt(index);

                }
                return tempList;
            }

        // Main
        static void Main(string[] args)
        {
            int[] arr = { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            int[] sortedArr = new int[arr.Length];


            // Biggest in the range 2 - 5
            int output = SortingMethod(2, 5, arr);
            Console.WriteLine(output);

            //

            

            int[] switchingList = SortingArray(arr).ToArray();

            foreach (var item in switchingList)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
