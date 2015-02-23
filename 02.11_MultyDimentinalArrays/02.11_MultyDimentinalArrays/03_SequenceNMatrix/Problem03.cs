using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SequenceNMatrix
{
    class Problem03
    {
        static void Main(string[] args)
        {
            // Input

            Console.Write("Enter Matrix height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter Matrix width: ");
            int width= int.Parse(Console.ReadLine());

            string[,] matrix = new string[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            // Horizontal check
            string temp = matrix[0,0];
            int currentCount = 1;
            int maxCount = 1;
            string toPrint = matrix[0, 0];

            for (int i = 0; i < height; i++)
            {
                temp = matrix[i, 0];
                for (int j = 1; j < width; j++)
                {
                    if (matrix[i,j] == temp)
                    {
                        currentCount++;
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            toPrint = matrix[i, j];
                        }
                    }
                    temp = matrix[i, j];
                }
                currentCount = 1;
            }

            // Vertical check
            temp = matrix[0, 0];

            for (int i = 0; i < width; i++)
            {
                temp = matrix[i, 0];
                for (int j = 1; j < height; j++)
                {
                    if (matrix[j, i] == temp)
                    {
                        currentCount++;
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            toPrint = matrix[j, i];
                        }
                    }
                    temp = matrix[j, i];
                }
                currentCount = 1;
            }

            // Diagonal check
            temp = matrix[0, 0];


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                }
            }


            // Output
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0}, ", toPrint);
            }


        }
    }
}
