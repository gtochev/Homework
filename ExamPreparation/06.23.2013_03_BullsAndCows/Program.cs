using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._23._2013_03_BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input
            string number = Console.ReadLine();
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            int[] matrix = new int[4];
            int[] matrixMed = new int[4];
            

            // Filling the matrixes
            for (int i = 0; i < 4; i++)
            {
                matrix[i] = number[i] - '0';
            }
            for (int i = 0; i < 4; i++)
            {
                matrixMed[i] = matrix[i];
            }

            // Exclusion
            if ((bulls == 3 && cows >= 1) ||
                (bulls == 3 && cows >= 2) ||
                (bulls == 2 && cows >= 3) ||
                (bulls == 1 && cows >= 4) ||
                (bulls>= 5) || (cows >= 5) ||
                (bulls < 0) || (cows < 0))
            {
                Console.WriteLine("No");
            }
            // 3 bulls no cows
            if (bulls == 3)
            {
                for (int i = 1; i < 9; i++)
                {
                    
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[j] != i)
                        {
                            
                        matrix[j] = i;
                        for (int k = 0; k < 4; k++)
                        {
                            Console.Write(matrix[k]);
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            matrix[k] = matrixMed[k];
                        }

                        Console.Write(" ");
                            
                        }
                    }
                }
            }
            

            // Matrix check
            //for (int k = 0; k < 4; k++)
            //{
            //    Console.Write(matrix[i]);
            //}
            //Console.WriteLine();
        }
    }
}
