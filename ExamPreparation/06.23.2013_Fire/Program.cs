using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._23._2013_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            double heightDouble = width * 1.375;
            int height = Convert.ToInt16(heightDouble);
            int counter = 0;
            int botHeight = width / 2 - 1;


            // Printing top
            Console.Write(new string('.', (width / 2) - 1));
            Console.Write("##");
            Console.Write(new string('.', (width / 2) - 1));
            Console.WriteLine();

            for (int i = 0; i < width / 2 - 1; i++)
            {
                Console.Write(new string('.', width / 2 - counter - 2));
                Console.Write("#");
                Console.Write(new string('.', 1 + counter));
                Console.Write(new string('.', 1 + counter));
                Console.Write("#");
                Console.Write(new string('.', width / 2 - counter - 2));
                Console.WriteLine();
                counter++;
            }
            counter = 0;
            // Printing mid fire
            for (int i = 0; i < width / 4; i++)
            {
                Console.Write(new string('.', counter));
                Console.Write("#");
                Console.Write(new string('.', width / 2 - counter - 1));
                Console.Write(new string('.', width / 2 - counter - 1));
                Console.Write("#");
                Console.Write(new string('.', counter));
                Console.WriteLine();
                counter++;
            }
            counter = 0;
            // Printing the mid
            Console.WriteLine(new string('-', width));

            //Printing the bott
            for (int i = 0; i < botHeight + 1; i++)
            {
                Console.Write(new string('.', counter));
                Console.Write(new string('\\', width / 2 - counter));
                Console.Write(new string('/', width / 2 - counter));
                Console.Write(new string('.', counter));
                Console.WriteLine();
                counter++;
            }
        }
    }
}
    