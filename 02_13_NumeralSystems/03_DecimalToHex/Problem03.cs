using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecimalToHex
{
    class Problem03
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int decNum = int.Parse(Console.ReadLine());
            int output = decNum;
            int leftover = 0;
            List<char> hexNum = new List<char>();

            while (decNum != 0)
            {
                leftover = decNum % 16;
                decNum = decNum / 16;
                switch (leftover)
                {
                    case 0: hexNum.Add('0'); break;
                    case 1: hexNum.Add('1'); break;
                    case 2: hexNum.Add('2'); break;
                    case 3: hexNum.Add('3'); break;
                    case 4: hexNum.Add('4'); break;
                    case 5: hexNum.Add('5'); break;
                    case 6: hexNum.Add('6'); break;
                    case 7: hexNum.Add('7'); break;
                    case 8: hexNum.Add('8'); break;
                    case 9: hexNum.Add('9'); break;
                    case 10: hexNum.Add('A'); break;
                    case 11: hexNum.Add('B'); break;
                    case 12: hexNum.Add('C'); break;
                    case 13: hexNum.Add('D'); break;
                    case 14: hexNum.Add('E'); break;
                    case 15: hexNum.Add('F'); break;
                    default:
                        break;
                }
            }
            hexNum.Reverse();
            foreach (var item in hexNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
