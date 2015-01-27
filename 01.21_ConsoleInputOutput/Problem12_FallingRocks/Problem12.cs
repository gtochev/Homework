using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// Не е изцяло завършена, но могат да се добавят другите бомби както @... Просто щеше да изглежда грозно целия код
// Сигурно има много по-добри начини изписване, но до тук ми стигнаха силите с моментните познания
namespace Problem12_FallingRocks
{
    class Problem12
    {
        static int dwarfPosition = 38;
        static int randomBombX = 35;
        static int randomBombFall = 0;
        static int score = 0;

        static void RemoveScrollbars()        
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        static void PrintAtPosition(int x, int y, int bomb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(bomb);
        }

        static void DrawDwarf()
        {
            char leftHand = '(';
            char dwarfHead = 'O';
            char rightHand = ')';
            Console.SetCursorPosition(dwarfPosition, Console.WindowHeight -1);
            Console.Write(leftHand);
            Console.SetCursorPosition(dwarfPosition + 1, Console.WindowHeight - 1);
            Console.Write(dwarfHead);
            Console.SetCursorPosition(dwarfPosition + 2, Console.WindowHeight - 1);
            Console.Write(rightHand);
        }
        
        static void DrawRandomBomb()
        {
            
            if (randomBombFall < Console.WindowHeight)
            {
                char bombChar = '@';
                Console.SetCursorPosition(randomBombX, randomBombFall);
                Console.Write(bombChar);
                randomBombFall++;
            }
            else
            {
                randomBombFall = 0;
                Random randomNumberGenerator = new Random();
                randomBombX = randomNumberGenerator.Next(0, Console.WindowWidth);
            }
        }
        
        static void MoveDwarf()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    dwarfPosition--;
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    dwarfPosition++;
                }
            }            
        }
        
        static void Main(string[] args)
        {
            
            while (true)
            {

                RemoveScrollbars();
                Console.Clear();
                DrawRandomBomb();

                if ((dwarfPosition == randomBombX && randomBombFall == Console.WindowHeight - 1) ||
                        (dwarfPosition + 1 == randomBombX && randomBombFall == Console.WindowHeight - 1) ||
                        (dwarfPosition + 2 == randomBombX && randomBombFall == Console.WindowHeight - 1))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("GAME OVER! Your Score is{0}", score);
                    return;
                }

                DrawDwarf();
                MoveDwarf();
                score += 10;
                Thread.Sleep(150);

            }
        }
    }
}
