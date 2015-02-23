using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HexToDec
{
    class Problem04
    {
        static int Stepenuvane(int times)
        {
            int output = 1;

            for (int i = 0; i < times; i++)
            {
                output *= 16;
                if (times == 0)
                {
                    break;
                }
            }

            return output;
        }

        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            int decNum = 0;
            int multiply = hexNum.Length - 1;

            for (int i = 0; i < hexNum.Length; i++)
            {
                switch (hexNum[i])
                {
                    case '0': decNum += 0; break;
                    case '1': decNum += 1 * (Stepenuvane(multiply)); break;
                    case '2': decNum += 2 * (Stepenuvane(multiply)); break;
                    case '3': decNum += 3 * (Stepenuvane(multiply)); break;
                    case '4': decNum += 4 * (Stepenuvane(multiply)); break;
                    case '5': decNum += 5 * (Stepenuvane(multiply)); break;
                    case '6': decNum += 6 * (Stepenuvane(multiply)); break;
                    case '7': decNum += 7 * (Stepenuvane(multiply)); break;
                    case '8': decNum += 8 * (Stepenuvane(multiply)); break;
                    case '9': decNum += 9 * (Stepenuvane(multiply)); break;
                    case 'A': decNum += 10 * (Stepenuvane(multiply)); break;
                    case 'B': decNum += 11 * (Stepenuvane(multiply)); break;
                    case 'C': decNum += 12 * (Stepenuvane(multiply)); break;
                    case 'D': decNum += 13 * (Stepenuvane(multiply)); break;
                    case 'E': decNum += 14 * (Stepenuvane(multiply)); break;
                    case 'F': decNum += 15 * (Stepenuvane(multiply)); break;
                    default:
                        break;
                }
                multiply--;
            }
            Console.WriteLine(decNum);
        }
    }
}
