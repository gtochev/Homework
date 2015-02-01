using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RandomizeTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] matrix = new int[n];
            Random rnd = new Random();
            int random = rnd.Next(0, n);
            

            for (int i = 0; i < n; i++)
            {
                matrix[i] = random;
                random = rnd.Next(0, n);
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (matrix[j] != matrix[j])
                    {
                        continue;
                    }
                    else
                    {
                        random = rnd.Next(0, n);
                        matrix[j] = random;
                        i = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
			{
			    Console.Write("{0} ", matrix[i]);
			}
        }
    }
}
