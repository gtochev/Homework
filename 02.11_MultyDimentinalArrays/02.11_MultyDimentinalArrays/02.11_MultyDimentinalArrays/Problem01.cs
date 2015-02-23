using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FillTheMatrix
{
    class Problem01
    {
        static void Main(string[] args)
        {
            // a) ----------------------------------------------
            Console.Write("Enter size of matrix: ");
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];
            int counter = 1;

            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }

            // Printing the matrix

            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    Console.Write("{0} ", matrix[row, col]); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // b) ----------------------------------------------
            int reverseCounter = sizeMatrix - 1;
            counter = 1;

            for (int row = 0; row < sizeMatrix; row++)
            {

                
                for (int col = 0; col < sizeMatrix; col++)
                {
                    if (row % 2 == 0)
                    {
                       matrix[col, row] = counter; 
                    }
                    else
                    {
                        matrix[reverseCounter, row] = counter; 
                    }
                    reverseCounter--;
                    counter++;
                }
                reverseCounter = sizeMatrix - 1;
            }

            // Printing the matrix

            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            // c) -----------------------------------------
            Console.WriteLine();

            int firstCounter = 1;
            int secondCounter = 1;
            int thirdCounter = 0;

            // Filling first half

            for (int i = sizeMatrix - 1; i >= 0; i--)
            {
                secondCounter = i;
                for (int j = 0; j <= thirdCounter; j++)
                {
                    matrix[secondCounter, j] = firstCounter;
                    firstCounter++;
                    secondCounter++;
                }
                thirdCounter++;

            }

            // Filling second half
            secondCounter = 1;
            thirdCounter = sizeMatrix - 1;

            for (int i = 1; i < sizeMatrix; i++)
            {
                secondCounter = i;
                for (int j = 0; j < thirdCounter; j++)
                {
                    matrix[j, secondCounter] = firstCounter;
                    firstCounter++;
                    secondCounter++;
                }
                thirdCounter--;
            }

            // Printing the matrix

            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
