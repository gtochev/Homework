using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Problem01_C
    {
        // Static vars
        static int sizeMatrix;
        static int[,] matrix;
        static int fillingElements = 1;
        static int globalRow = 0;
        static int globalCol = 0;

        // Method Down
        static void FillingDown(int row, int col)
        {
            while (row < sizeMatrix && matrix[row, col] == 0)
            {
                matrix[row, col] = fillingElements;
                fillingElements++;
                row++;
            }
            row--;
            globalRow = row;
            globalCol = col;
        }

        // Method Right
        static void FillingRight(int row, int col)
        {
            while (col < sizeMatrix && matrix[row, col] == 0)
            {
                matrix[row, col] = fillingElements;
                fillingElements++;
                col++;
            }
            col--;
            globalRow = row;
            globalCol = col;
        }

        // Method Up
        static void FillingUp(int row, int col)
        {
            while (row >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = fillingElements;
                fillingElements++;
                row--;
            }
            row++;
            globalRow = row;
            globalCol = col;
        }

        // Method Left
        static void FillingLeft(int row, int col)
        {
            while (col >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = fillingElements;
                fillingElements++;
                col--;
            }
            col++;
            globalRow = row;
            globalCol = col;
        }

        // Main
        static void Main(string[] args)
        {
            // Creating the matrix
            Console.Write("Enter size of matrix: ");
            sizeMatrix = int.Parse(Console.ReadLine());
            matrix = new int[sizeMatrix, sizeMatrix];

            // Logic

            while (fillingElements <= sizeMatrix * sizeMatrix)
            {
                FillingDown(globalRow, globalCol);
                globalCol++;
                FillingRight(globalRow, globalCol);
                globalRow--;
                FillingUp(globalRow, globalCol);
                globalCol--;
                FillingLeft(globalRow, globalCol);
                globalRow++;
                
            }

            // Printing the matrix
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("{0}   ", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
