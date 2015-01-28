using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2013_03_Evening_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int imput = int.Parse(Console.ReadLine());
            int height = 6 + ((imput - 3) / 2) * 3;
            int width = imput * 2 + 1;

            int[,] matrix = new int[height, width];


            //Performing the logic
            int currentRow = 0;
            int currentCol = width / 2;

            // From mid-top to mid-right
            while (true)//(currentCol < width)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
                currentCol++;

                if (currentCol > width - 1)
                {
                    currentRow--;
                    currentCol--;
                    break;
                }
            }
            // From mid-right to down-right
            while (true)//(currentRow < height)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;
                currentCol--;

                if (currentRow > height -1)//(currentCol > width)
                {
                    currentRow--;
                    currentCol++;
                    break;
                }
            }
            // from down-right to down-left
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol--;
                if (currentCol < (width - imput) / 2)
                {
                    currentCol++;
                    break;
                    
                }
            }
            // from down-right to left-mid
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow--;
                currentCol--;
                if (currentCol < 0)
                {
                    currentCol++;
                    currentRow++;
                    break;
                }
            }
            // from left-mid to top-mid
            while(true)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow--;
                currentCol++;

                if (currentRow < 0)
                {
                    currentRow++;
                    currentCol--;
                    break;
                }
            }
            // from top-mid to bot-mid
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentRow++;

                if (currentRow > height - 1)
                {
                    break;
                }
            }
            // from left-mid to right-mid
            currentRow = (height * 2 / 3) - 1;
            currentCol = 0;
            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol++;
                if (currentCol > width -1)
                {
                    break;                    
                }
            }

            //-------------------------------------------------------------------------------
            //Filling the matrix
            //-------------------------------------------------------------------------------
            
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }


            //Output
        }
    }
}
