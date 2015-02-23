using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static int setLenght = 0;

        // Minimum
        static void Minimum(float[] arr)
        {
            float min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The minimum of the set is {0}", min);
        }

        // Maximum
        static void Maximum(float[] arr)
        {
            float max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The minimum of the set is {0}", max);
        }

        // Average
        static void Average(float[] arr)
        {
            float average = 0;

            for (int i = 0; i < setLenght; i++)
            {
                average += arr[i];
            }
            average = average / setLenght;
            Console.WriteLine("The average of the set is {0}", average);
        }

        // Sum
        static void Sum(float[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of the set is {0}", sum);
        }

        // Product
        static void Product(float[] arr)
        {
            float product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("The product of the set is {0}", product);
        }

        static void Main(string[] args)
        {
            // Input and filling the arr with the set
            Console.Write("Enter set lenght: ");
            setLenght = int.Parse(Console.ReadLine());
            float[] setArr = new float[setLenght];
            Console.WriteLine("Enter {0} numbers on separate line", setLenght);
            for (int i = 0; i < setArr.Length; i++)
            {
                setArr[i] = int.Parse(Console.ReadLine());
            }
            // Methods
            Minimum(setArr);
            Maximum(setArr);
            Average(setArr);
            Sum(setArr);
            Product(setArr);

        }
    }
}
