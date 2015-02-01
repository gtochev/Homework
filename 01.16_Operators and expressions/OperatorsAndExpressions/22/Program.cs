using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            if ((number >> position & 1) == 1)
            {
                Console.WriteLine("1");
            }
            if ((number >> position & 1) == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
