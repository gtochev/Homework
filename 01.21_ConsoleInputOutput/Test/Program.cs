using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine("{0,10}", binaryNumber);
        }
    }
}
