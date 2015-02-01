using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_HexaToDec
{
    class Problem15
    {
        static void Main(string[] args)
        {
            string hexaNum = Console.ReadLine();
            int[] matrix = new int[hexaNum.Length];
            int counterN = 0;
            long mnojitel = 1;
            long decimalNum = 0;

            for (int i = hexaNum.Length - 1; i >= 0; i--)
            {
                switch (hexaNum[i])
                {
                    case '0': matrix[counterN] = 0; break;
                    case '1': matrix[counterN] = 1; break;
                    case '2': matrix[counterN] = 2; break;
                    case '3': matrix[counterN] = 3; break;
                    case '4': matrix[counterN] = 4; break;
                    case '5': matrix[counterN] = 5; break;
                    case '6': matrix[counterN] = 6; break;
                    case '7': matrix[counterN] = 7; break;
                    case '8': matrix[counterN] = 8; break;
                    case '9': matrix[counterN] = 9; break;
                    case 'A': matrix[counterN] = 10; break;
                    case 'B': matrix[counterN] = 11; break;
                    case 'C': matrix[counterN] = 12; break;
                    case 'D': matrix[counterN] = 13; break;
                    case 'E': matrix[counterN] = 14; break;
                    case 'F': matrix[counterN] = 15; break;
                    default:
                        break;
                }
                counterN++;
            }

            // Calculations
            decimalNum += matrix[0];


            for (int i = 1; i < matrix.Length; i++)
            {
                mnojitel = 1;
                for (int k = 1; k <= i; k++)
                {
                    mnojitel *= 16;
                }
                decimalNum += mnojitel * matrix[i];
            }

            Console.WriteLine(decimalNum);
        }
    }
}
