using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_13_NumeralSystems
{
    class Problem01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int numberDec = int.Parse(Console.ReadLine());

            // Easy way
            string binaryStr = Convert.ToString(numberDec, 2);
            Console.WriteLine(binaryStr);
            List<int> binary = new List<int>();
            int temp = 0;
            // 
            while (numberDec != 0)
            {
                binary.Add(numberDec % 2);
                numberDec = numberDec / 2;
            }
            binary.Reverse();
            foreach (var item in binary)
            {
                Console.Write(item);
            }
        }
    }
}
