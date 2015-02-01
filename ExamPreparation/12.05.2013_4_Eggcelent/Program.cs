using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2013_4_Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int number = int.Parse(Console.ReadLine());
            int row = (number * 2);
            int col = ((3 * number) + 1);
            int[,] matrix = new int[row, col];
            int currentRow = 1;
            int currentCol = number * 3;

            // Solution

            // Marking TOP
            for (int i = number + 1; i < (number * 2); i++)
            {
                matrix[0, i] = 1;
            }

            for (int j = (number * 2) + 1; j < (number * 3); j++)
			{
			    matrix[currentRow, j] = 1;
                currentRow++;
                currentCol = j;
                j++;
			}
            int medium = currentRow;
            for (int k = currentRow; k <= (number * 2) - medium +1; k++)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
            }
            for (int f = currentRow; f < number * 2; f++)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol -= 2;
                currentRow++;
            }
            for (int k = currentRow; k <= (number * 2) - medium; k++)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
            }


            // Printing
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        Console.Write('.');
                    }
                    if (matrix[i,j] == 1)
                    {
                        Console.Write('*');
                    }
                    if (matrix[i, j] == '2')
                    {
                        Console.Write('@');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
