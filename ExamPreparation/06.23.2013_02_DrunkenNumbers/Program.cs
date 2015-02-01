using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._23._2013_02_DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int rounds = int.Parse(Console.ReadLine());
            
            int mitko = 0;
            int vlado = 0;

            for (int f = 0; f < rounds; f++)
			{

                string number = Console.ReadLine();
                int[] matrix = new int[number.Length];

                int counter = 0;
                int newMatrixCounter = 0;
                
                // Filling the matrix with numbers
                for (int j = 0; j < number.Length; j++)
                {
                    matrix[j] = Convert.ToInt16(number[j] - '0');
                }

                // Counting numbers != 0
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i] != 0)
                    {
                        counter++;
                    }
                }
                // New matrix
                int[] newMatrix = new int[counter];
                // Filling the NEW matrix
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i] != 0)
                    {
                        newMatrix[newMatrixCounter] = matrix[i];
                        newMatrixCounter++;
                    }
                }
                // Counting
                if (counter % 2 != 0)
                {
                    for (int i = 0; i < newMatrix.Length / 2 + 1; i++)
                    {
                        mitko += newMatrix[i];
                    }
                    for (int i = newMatrix.Length / 2; i < newMatrix.Length; i++)
                    {
                        vlado += newMatrix[i];
                    }
                }
                else
                {
                    for (int i = 0; i < newMatrix.Length / 2; i++)
                    {
                        mitko += newMatrix[i];
                    }
                    for (int i = newMatrix.Length / 2; i < newMatrix.Length; i++)
                    {
                        vlado += newMatrix[i];
                    }
                }

                

                // Check
                //for (int r = 0; r < newMatrix.Length; r++)
                //{
                //    Console.Write(newMatrix[r]);
                //}

                //-------------------------------------------------------------
			}
            // Output
            if (mitko > vlado)
            {
                Console.WriteLine("M {0}", mitko - vlado);
            }
            if (vlado > mitko)
            {
                Console.WriteLine("V {0}", vlado - mitko);
            }
            if (mitko == vlado)
            {
                Console.WriteLine("No {0}", mitko + vlado);
            }
        }
    }
}
