using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BinToHex
{
    class Problem06
    {
        static void Main(string[] args)
        {
            string binNum = Console.ReadLine();
            char[] binArr = new char[32];
            for (int i = 0; i < binArr.Length; i++)
            {
                binArr[i] = '0';
            }
            int counter = 31;


            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                binArr[counter] = binNum[i];
                counter--;
            }

            counter = 31;

            char[] fourPair = new char[4];
            List<char> hexNum = new List<char>();
            

            //for (int i = 8 - 1; i >= 0; i--)
            for (int i = 0; i < 8; i++)
            {
                StringBuilder strBuild = new StringBuilder();

                for (int j = 4 - 1; j >= 0; j--)
                {
                    fourPair[j] = binArr[counter];
                    counter--;
                    strBuild.Append(fourPair[j]);
                }

                string reversed = strBuild.ToString();

                switch (reversed)
                {
                    case "0000": hexNum.Add('0'); break;
                    case "1000": hexNum.Add('1'); break;
                    case "0100": hexNum.Add('2'); break;
                    case "1100": hexNum.Add('3'); break;
                    case "0010": hexNum.Add('4'); break;
                    case "1010": hexNum.Add('5'); break;
                    case "0110": hexNum.Add('6'); break;
                    case "1110": hexNum.Add('7'); break;
                    case "0001": hexNum.Add('8'); break;
                    case "1001": hexNum.Add('9'); break;
                    case "0101": hexNum.Add('A'); break;
                    case "1101": hexNum.Add('B'); break;
                    case "0011": hexNum.Add('C'); break;
                    case "1011": hexNum.Add('D'); break;
                    case "0111": hexNum.Add('E'); break;
                    case "1111": hexNum.Add('F'); break;
                    default:
                        break;
                }

            }
            hexNum.Reverse();

            int removeZeroCounter = 0;
            while (hexNum[0] == '0')
            {
                hexNum.RemoveAt(0);
                removeZeroCounter++;
            }

            foreach (var item in hexNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
