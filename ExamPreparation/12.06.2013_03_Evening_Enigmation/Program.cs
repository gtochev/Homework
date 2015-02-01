using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2013_03_Evening_Enigmation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int imput = int.Parse(Console.ReadLine());
            int height = 6 + ((imput - 3) / 2) * 3;
            int width = imput * 2 + 1;
            int lqvoZnameY = ((height * 2) / 3) - 1;
            int dqsnoZnameY = 0;
            int lqvoGrebloY = ((height * 2) / 3) - 1;
            int dqsnoGrebloY = ((height * 2) / 3) - 1;

            //Solution
            //Tochki
            for (int tochkiX = 0; tochkiX < width ; tochkiX++)
			{
                Console.SetCursorPosition(tochkiX, 0);
                Console.WriteLine(".");
                for (int tochkiY = 0; tochkiY < height; tochkiY++)
                {
                    Console.SetCursorPosition(tochkiX, tochkiY);
                    Console.WriteLine(".");
                }
			}
            //Sreden horizontala zvezdi
            for (int zvezdiX = 0; zvezdiX < width; zvezdiX++)
            {
                Console.SetCursorPosition(zvezdiX, ((height * 2) / 3) - 1);
                Console.WriteLine("*");
            }
            //Sredna otves zvezdi
            for (int zvezdiY = 0; zvezdiY < height; zvezdiY++)
            {
                Console.SetCursorPosition((width / 2), zvezdiY);
                Console.WriteLine("*");
            }
            //Lqvo zname
            for (int lqvoZname = 0; lqvoZname < width / 2; lqvoZname++)
            {
                Console.SetCursorPosition(lqvoZname, lqvoZnameY);
                Console.WriteLine("*");
                lqvoZnameY--;
            }
            //Dqsno zname
            for (int dqsnoZnameX = width / 2; dqsnoZnameX < width; dqsnoZnameX++)
            {
                Console.SetCursorPosition(dqsnoZnameX, dqsnoZnameY);
                Console.WriteLine("*");
                dqsnoZnameY++;
            }
            //Lqvo greblo
            for (int lqvoGrebloX = 0; lqvoGrebloX < width / 3; lqvoGrebloX++)
            {
                Console.SetCursorPosition(lqvoGrebloX, lqvoGrebloY);
                Console.WriteLine("*");
                lqvoGrebloY++;
            }
            //Dqsno greblo
            for (int dqsnoGrebloX = width - 1; dqsnoGrebloX > (width * 2 / 3); dqsnoGrebloX--)
            {
                Console.SetCursorPosition(dqsnoGrebloX, dqsnoGrebloY);
                Console.WriteLine("*");
                dqsnoGrebloY++;
            }



            //End
            Console.SetCursorPosition(0, height + 1);
            Console.WriteLine();
        }
    }
}
