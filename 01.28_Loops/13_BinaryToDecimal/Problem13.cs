using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BinaryToDecimal
{
    class Problem13
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            int[] matrix = new int[binary.Length];
            long desetichno = 1;
            long result = 0;
            int counter = 0;

            // Filling and reversing the matrix
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    matrix[counter] = 1;
                }
                counter++;
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                desetichno *= 2;

                if (matrix[i] == 1)
                {
                    result += desetichno;
                }
            }

            if (matrix[0] == 1)
            {
                result += 1;
            }

            Console.WriteLine(result);

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    Console.Write(matrix[i]);
            //}
        }
    }
}
