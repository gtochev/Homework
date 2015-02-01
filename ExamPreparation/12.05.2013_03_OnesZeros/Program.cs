using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2013_03_OnesZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[5, 63];
            int col = 0;


            // Assignvane na 1-vi red
            col = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[0, col] = '#';
                    col++;
                }
                matrix[0, col] = '.';
                col++;
            }
            for (int j = 0; j < 3; j++)
            {
                matrix[0, col] = '#';
                col++;
            }
            Console.WriteLine();

            // Assignvane na 2-ri red
            col = 0;
            for (int i = 0; i <= 63; i++)
            {
                matrix[1,i] = '#';
                col++;
                i++;
            }
            col = 0;
            for (int i = 1; i < 63; i++)
            {
                matrix[1, i] = '.';
                col++;
                i++;
            }

            // Assignvane na 3-ti red
            col = 0;
            for (int i = 0; i <= 63; i++)
            {
                matrix[2, i] = '#';
                col++;
                i++;
            }
            for (int i = 1; i < 63; i++)
            {
                matrix[2, i] = '.';
                col++;
                i++;
            }

            // Assignvane na 4-ti red
            col = 0;
            for (int i = 0; i <= 63; i++)
            {
                matrix[3, i] = '#';
                col++;
                i++;
            }
            for (int i = 1; i < 63; i++)
            {
                matrix[3, i] = '.';
                col++;
                i++;
            }
            // Assignvane na 5-ti red
            col = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[4, col] = '#';
                    col++;
                }
                matrix[4, col] = '.';
                col++;
            }
            for (int j = 0; j < 3; j++)
            {
                matrix[4, col] = '#';
                col++;
            }

            // Intput
            int number = int.Parse(Console.ReadLine());
            
            string numberStr = Convert.ToString(number, 2).PadLeft(64, '0'); //!!!
            char[] ednomerna = new char[numberStr.Length];

            for (int i = 0; i < numberStr.Length; i++)
            {
                ednomerna[i] = numberStr[i];
            }

            // Purvi red
            int colon = 0;
            for (int i = 48; i < 64; i++)
            {
                if (ednomerna[i] == '1')
                {
                    matrix[0,colon] = '.';
                    matrix[2,colon] = '.';
                    matrix[3, colon] = '.';
                    matrix[0, colon + 2] = '.';
                    matrix[1, colon + 2] = '.';
                    matrix[2, colon + 2] = '.';
                    matrix[3, colon + 2] = '.';
                    matrix[1, colon + 1] = '#';
                    matrix[2, colon + 1] = '#';
                    matrix[3, colon + 1] = '#';

                }
                colon += 4;
            }

            // Printirane
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 63; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
