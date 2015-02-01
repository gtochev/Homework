using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadranachi
{
    class Program
    {

        //MAIN ------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            // Defining lines and array (input)
            int number = int.Parse(Console.ReadLine());
            int tildaP = 0;
            int tochkiP = 0;
            int medium = 0;
            int output = 0;
            int[] matrixOne = new int[number];
            string numbersLenght = string.Empty;

            

            // Filling the array (input)
            for (int f = 0; f < number; f++)
            {
                matrixOne[f] = int.Parse(Console.ReadLine());
            }

            // Alrogirtm

            for (int i = 0; i < number; i++)
            {
                numbersLenght = Convert.ToString(matrixOne[i], 2);
                medium = matrixOne[i];

                tildaP = 0;

                for (int k = 0; k < numbersLenght.Length; k++)
                {
                    // Namirane na TildaP

                    tildaP <<= 1;
                    tildaP = tildaP | 1;

                }
                tildaP = tildaP ^ matrixOne[i];

                for (int l = 0; l < numbersLenght.Length; l++)
                {
                    tochkiP <<= 1;
                    tochkiP |= (medium & 1);
                    medium >>= 1;
                }

                output = ((matrixOne[i] ^ tildaP) & tochkiP);
                Console.WriteLine(output);

            }

            //
        }
    }
}
/*
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            
            string representation = Convert.ToString(number, 2);
            Console.WriteLine(representation);
            

            for (int i = 0; i < representation.Length; i++)
            {
                reverse <<= 1;
                reverse |= (number & 1);
                number >>= 1;
            }
            representation = Convert.ToString(reverse, 2);
            Console.WriteLine(representation);
*/