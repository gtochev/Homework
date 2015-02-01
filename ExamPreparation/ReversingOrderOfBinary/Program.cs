using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingOrderOfBinary
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(reverse);
        }
    }
}

/*
 uint y = 0;
for (int i = 0; i < 32; ++i)
{
y <<= 1;
y |= (x & 1);
x >>= 1;
}
 */