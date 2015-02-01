using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertingOrderOfBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int binary = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(binary, 2));
            string binaryLenght = Convert.ToString(binary, 2);
            int invert = 1;

            for (int i = 1; i < binaryLenght.Length; i++)
            {
                invert <<= 1;
                invert = invert | 1;
            }
            invert = invert ^ binary;
            Console.WriteLine(Convert.ToString(invert, 2));

        }
    }
}
