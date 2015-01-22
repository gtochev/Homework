using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Problem05
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(a, 2);
            Console.Write("{0:x}", a);
            Console.Write("|{0}|", binaryNumber);
            Console.Write("{0:F2}", b);
            Console.WriteLine("|{0,-6:F3}|", c);
        }
    }
}
