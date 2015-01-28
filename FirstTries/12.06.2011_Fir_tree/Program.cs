using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2011_Fir_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imput and finding the colomns
            int imput = int.Parse(Console.ReadLine());
            int numberCol = 1;

            for (int counter = 1; counter < imput - 1; counter++)
            {
                numberCol = numberCol + 2;
            }
            int[,] matrix = new int[imput, numberCol];
            int currentRow = 0;
            int currentCol = 0;

            // Solution logic

            // Left part of the tree
            int leftNumberCol = numberCol / 2;

            for (currentRow = 0; currentRow < imput; currentRow++)
            {
                for (currentCol = 0; currentCol < leftNumberCol; currentCol++)
                {
                    matrix[currentRow, currentCol] = 1;
                }
                leftNumberCol--;
            }

            // Right part of the tree
            int rightNumberCol = numberCol / 2 + 1;

            for (currentRow = 0; currentRow < imput - 1; currentRow++)
            {
                for (currentCol = rightNumberCol; currentCol < numberCol; currentCol++)
                {
                    matrix[currentRow, currentCol] = 1;
                }
                rightNumberCol++;
            }

            // The base
            for (currentCol = 0; currentCol < numberCol; currentCol++)
            {
                matrix[imput - 1, currentCol] = 1;
            }
            matrix[imput - 1, numberCol / 2] = 0;

            // Printing

            for (int row = 0; row < imput; row++)
            {
                for (int col = 0; col < numberCol; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write("*");
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
/*
.......*.......
......***......
.....*****.....
....*******....
...*********...
..***********..
.*************.
***************
.......*.......
*/