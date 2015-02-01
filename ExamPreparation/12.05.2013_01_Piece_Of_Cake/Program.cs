using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _12._05._2013_01_Piece_Of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal upperA = int.Parse(Console.ReadLine());
            decimal lowerB = int.Parse(Console.ReadLine());
            decimal upperC = int.Parse(Console.ReadLine());
            decimal lowerD = int.Parse(Console.ReadLine());
            decimal fullCake = 0;

            fullCake = (upperA / lowerB) + (upperC / lowerD);

            if (fullCake >= 1 )
            {
                Console.WriteLine(Math.Floor(fullCake));
            }
            else
            {
                Console.WriteLine("{0:F22}", fullCake);   
            }
            Console.WriteLine("{0}/{1}", ((upperA * lowerD) + (upperC * lowerB)), (lowerB * lowerD));
        }
    }
}
