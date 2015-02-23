using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaximalSum
{
    class Problem02
    {
        static void Main(string[] args)
        {
            // Input

            Console.Write("Enter size of matrix: ");
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //
            int currentSum = 0;
            int maxSum = 0;
            for (int row = 0; row < sizeMatrix - 2; row++)
            {
                for (int col = 0; col < sizeMatrix - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            
            // 

            Console.WriteLine(maxSum);
        }
    }
}
