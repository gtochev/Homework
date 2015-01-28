using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2011_01_Ship_damage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int sX1 = int.Parse(Console.ReadLine());
            int sY1 = int.Parse(Console.ReadLine());
            int sX2 = int.Parse(Console.ReadLine());
            int sY2 = int.Parse(Console.ReadLine());

            int horizon = int.Parse(Console.ReadLine());

            int cX1 = int.Parse(Console.ReadLine());
            int cY1 = int.Parse(Console.ReadLine());
            int cX2 = int.Parse(Console.ReadLine());
            int cY2 = int.Parse(Console.ReadLine());
            int cX3 = int.Parse(Console.ReadLine());
            int cY3 = int.Parse(Console.ReadLine());

            // Setting the horizon on ZERO, and bombs over the horizon
            sY1 = ((sY1 - horizon));
            sY2 = ((sY2 - horizon));
            cY1 = ((cY1 - horizon) * - 1);
            cY2 = ((cY2 - horizon) * - 1);
            cY3 = ((cY3 - horizon) * - 1);

            // Arranging the Ship NEW coordinates
            int shipLDownX = 0;
            int shipLDownY = 0;
            int shipRUpX = 0;
            int shipRUpY = 0;

            // Setting the ship
            if (sX1 > sX2)
            {
                shipLDownX = sX2;
                shipRUpX = sX1;
            }
            else
            {
                shipLDownX = sX1;
                shipRUpX = sX2;
            }
            if (sY1 > sY2)
            {
                shipLDownY = sY2;
                shipRUpY = sY1;

            }
            else
            {
                shipLDownY = sY1;
                shipRUpY = sY2;
            }

            // Solution Logic
            int damage = 0;
            // Tochni popadeniq
            if ((cX1 > shipLDownX) && (cX1 < shipRUpX) && (cY1 > shipLDownY) && (cY1 < shipRUpY))
            {
                damage += 100;
            }
            if ((cX2 > shipLDownX) && (cX2 < shipRUpX) && (cY2 > shipLDownY) && (cY2< shipRUpY))
            {
                damage += 100;
            }
            if ((cX3 > shipLDownX) && (cX3 < shipRUpX) && (cY3 > shipLDownY) && (cY3 < shipRUpY))
            {
                damage += 100;
            }

            // Popadeniq po vurha
            if (((cX1 == shipLDownX) && ((cY1 == shipLDownY) || (cY1 == shipRUpY))) ||
                ((cX1 == shipRUpX) && ((cY1 == shipLDownY) || (cY1 == shipRUpY))))
            {
                damage += 25;
            }
            if (((cX2 == shipLDownX) && ((cY2 == shipLDownY) || (cY2 == shipRUpY))) ||
                ((cX2 == shipRUpX) && ((cY2 == shipLDownY) || (cY2 == shipRUpY))))
            {
                damage += 25;
            }
            if (((cX3 == shipLDownX) && ((cY3 == shipLDownY) || (cY3 == shipRUpY))) ||
                ((cX3 == shipRUpX) && ((cY3 == shipLDownY) || (cY3 == shipRUpY))))
            {
                damage += 25;
            }

            // Popadeniq po ruba
            if ((((cX1 == shipLDownX) && ((cY1 > shipLDownY) && (cY1 < shipRUpY))) ||
                ((cX1 == shipRUpX) && ((cY1 > shipLDownY) && (cY1 < shipRUpY)))) ||
                ((cY1 == shipLDownY) && ((cX1 > shipLDownX) || (cX1 < shipRUpX))) ||
                ((cY1 == shipRUpY) && ((cX1 > shipLDownX) || (cX1 < shipRUpX))))
            {
                damage += 50;
            }
            if ((((cX2 == shipLDownX) && ((cY2 > shipLDownY) && (cY2 < shipRUpY))) ||
                ((cX2 == shipRUpX) && ((cY2 > shipLDownY) && (cY2 < shipRUpY)))) ||
                ((cY2 == shipLDownY) && ((cX2 > shipLDownX) || (cX2 < shipRUpX))) ||
                ((cY2 == shipRUpY) && ((cX2 > shipLDownX) || (cX2 < shipRUpX))))
            {
                damage += 50;
            }
            if ((((cX3 == shipLDownX) && ((cY3 > shipLDownY) && (cY3 < shipRUpY))) ||
                ((cX3 == shipRUpX) && ((cY3 > shipLDownY) && (cY3 < shipRUpY)))) ||
                ((cY3 == shipLDownY) && ((cX3 > shipLDownX) || (cX3 < shipRUpX))) ||
                ((cY3 == shipRUpY) && ((cX3 > shipLDownX) || (cX3 < shipRUpX))))
            {
                damage += 50;
            }

            // Output
            Console.WriteLine(damage + "%");
        }
    }
}
