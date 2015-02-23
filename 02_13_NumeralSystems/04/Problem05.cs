using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Problem05
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            List<string> binary = new List<string>();
            for (int i = 0; i < hexNum.Length; i++)
            {
                switch (hexNum[i])
                {
                    case '0': binary.Add("0000"); break;
                    case '1': binary.Add("0001"); break;
                    case '2': binary.Add("0010"); break;
                    case '3': binary.Add("0011"); break;
                    case '4': binary.Add("0100"); break;
                    case '5': binary.Add("0101"); break;
                    case '6': binary.Add("0110"); break;
                    case '7': binary.Add("0111"); break;
                    case '8': binary.Add("1000"); break;
                    case '9': binary.Add("1001"); break;
                    case 'A': binary.Add("1010"); break;
                    case 'B': binary.Add("1011"); break;
                    case 'C': binary.Add("1100"); break;
                    case 'D': binary.Add("1101"); break;
                    case 'E': binary.Add("1110"); break;
                    case 'F': binary.Add("1111"); break;
                    default:
                        break;
                }
            }
            string binStr = string.Join("",binary.ToArray());
            string binstrOut = binStr.TrimStart('0');

            foreach (var item in binstrOut)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
