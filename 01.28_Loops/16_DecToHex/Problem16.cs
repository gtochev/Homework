using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DecToHex
{
    class Problem16
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string[] matrix = new string[10];
            long leftover = 0;
            long counter = 0;

            while (true)
            {
                number = number / 16;
                leftover = number % 16;
                //Console.Write();
                switch (leftover)
                {
                    case 0: matrix[counter] = "0"; break;
                    case 1: matrix[counter] = "1"; break;
                    case 2: matrix[counter] = "2"; break;
                    case 3: matrix[counter] = "3"; break;
                    case 4: matrix[counter] = "4"; break;
                    case 5: matrix[counter] = "5"; break;
                    case 6: matrix[counter] = "6"; break;
                    case 7: matrix[counter] = "7"; break;
                    case 8: matrix[counter] = "8"; break;
                    case 9: matrix[counter] = "9"; break;
                    case 10: matrix[counter] = "A"; break;
                    case 11: matrix[counter] = "B"; break;
                    case 12: matrix[counter] = "C"; break;
                    case 13: matrix[counter] = "D"; break;
                    case 14: matrix[counter] = "E"; break;
                    case 15: matrix[counter] = "F"; break;
                    default:
                        break;
                }
                //counter++;
            }
        }
    }
}
