using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BinaryToDecimal
{
    class Problem02
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();

            //char[] binaryArr = new char[binaryRev.Length];
            //int counter = 0;
            //for (int i = binaryArr.Length - 1; i >= 0; i--)
            //{
            //    binaryArr[i] = binaryRev[counter];
            //    counter++;
            //}

            int decimalNum = 0;

            if (binary[binary.Length - 1] == '1')
            {
                decimalNum = 1;
            }
            else
            {
                decimalNum = 0;
            }


            int stepenuvane = 1;
            int secondCounter = binary.Length;

            foreach (var item in binary)
            {
                if (item == '1')
                {
                    for (int i = 0; i < secondCounter - 1; i++)
                    {
                        stepenuvane *= 2;
                    }
                    decimalNum += stepenuvane;
                }
                secondCounter--;
                stepenuvane = 1;
            }
            Console.WriteLine(decimalNum);
        }
    }
}
