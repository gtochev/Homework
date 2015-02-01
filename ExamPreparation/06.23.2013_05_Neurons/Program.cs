using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._23._2013_05_Neurons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[32,32];
            string binaryStr = string.Empty;
            bool neuronBoundary = false;
            bool neuronIn = false;
            int counter = 0;
            int output = 0;
            int desetichno = 1;
            int result = 0;

            // Input & filling the matrix
            while (true)
            {
                int binary = int.Parse(Console.ReadLine());

                if (binary == -1)
                {
                    break;
                }

                binaryStr = Convert.ToString(binary, 2).PadLeft(32, '0');

                for (int i = 0; i < 32; i++)
                {
                    matrix[counter, i] = binaryStr[i] - '0';
                }
                counter++;
            }

            // Solution logic
            for (int row = 0; row < counter; row++)
            {
                for (int col = 0; col < 32; col++)
                {
                    if (matrix[row, col] == 1 && neuronIn == false)
                    {
                        matrix[row, col] = 0;
                        neuronIn = true;
                    }
                    else if (neuronIn == true && matrix[row, col] == 0)
                    {
                        matrix[row, col] = 1;
                    }
                    else if (matrix[row, col] == 1 && neuronIn == true)
                    {
                        matrix[row, col] = 0;
                        neuronIn = false;
                    }
                }
                neuronIn = false;
            }

            // Output


            // Check with printing the matrix
            //for (int i = 0; i < counter; i++)
            //{
            //    for (int j = 0; j < 32; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
