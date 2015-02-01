using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetReda
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int numbertwo = 5;
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k <= numbertwo; k++)
                {
                    Console.Write('*');
                }
                numbertwo--;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
