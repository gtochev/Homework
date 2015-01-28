using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2011_04_Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int[,] matrix = new int[8, 8];
            int number = 0;
            string binary = string.Empty;
            int pillar = 1;
            int counterLeft = 0;
            int counterRight = 0;
            int colomn = 6;

            for (int i = 0; i < 8; i++)
            {
                number = int.Parse(Console.ReadLine());
                binary = Convert.ToString(number, 2).PadLeft(8, '0');

                for (int j = 7; j >= 0; j--)
                {
                    matrix[i, j] =  binary[j];
                }
            }

            // Printing the matrix
            //for (int l = 0; l < 8; l++)
            //{
            //    for (int k = 0; k < 8; k++)
            //    {
            //        if (matrix[l,k] == '0')
            //        {
            //            Console.Write('.');
            //        }
            //        if (matrix[l, k] == '1')
            //        {
            //            Console.Write('*');
            //        }
                    
            //    }
            //    Console.WriteLine();
            //}


            for (int j = 1; j < 7; j++) // ????
            {
                counterLeft = 0;
                counterRight = 0;
                // Counting Left of Pillar
                for (int i = 0; i < 8; i++)
                {
                    for (int m = 0; m < pillar; m++)
                    {
                        if (matrix[i, m] == '1')
                        {
                            counterLeft++;
                        }
                    }
                    
                }
                // Counting Right of pillar
                for (int k = 0; k < 8; k++)
                {
                    for (int n = pillar + 1; n < 8; n++)
                    {
                        if (matrix[k, n] == '1')
                        {
                            counterRight++;
                        } 
                    }
                }
                // Output
                
                if (counterRight == counterLeft)
                {
                    Console.WriteLine(colomn);
                    Console.WriteLine(counterRight);
                    break;
                }

                pillar++;
                if (pillar >6)
                {
                    Console.WriteLine("No");
                    break;
                }
                colomn--;
            }
        }
    }
}
