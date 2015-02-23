using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _13_SolveTasks
{
    class Problem13
    {
        // Main menu
        static void MainMenu()
        {
            Console.WriteLine("Choose task to complete:");
            Console.WriteLine("Press 1 for number reverse");
            Console.WriteLine("Press 2 for average of sequence");
            Console.WriteLine("Press 3 to solve the linear equation: a * x + b = 0");
            Console.WriteLine("Press 4 to exit");
        }

        // Reversing a number
        static void ReverseNumber()
        {
            Console.Write("Enter non-negative number to reverse: ");
            string input = Console.ReadLine();
            Console.Clear();
            if (input[0] == '-')
            {
                Console.WriteLine("********Number is negative********");
                ReverseNumber();
            }
            else
            {
                char[] charArray = input.ToCharArray();
                string output = string.Empty;

                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    output += charArray[i];
                }
                Console.WriteLine("Reversed number is: " + output);
                Console.WriteLine();
            }
            
        }

        // Average of sequence
        static void AverageSequence()
        {
            Console.Write("How many numbers in the sequence: ");
            float sequence = float.Parse(Console.ReadLine());
            float sum = 0;
            Console.Clear();
            Console.WriteLine("Enter {0} numbers on separate line", sequence);
            Console.WriteLine();
            for (int i = 0; i < sequence; i++)
            {
                sum += float.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("The average of the sequence is: {0}", (sum / sequence));
            Console.WriteLine();
        }

        // Linear equation
        static void LinearEquation()
        {
            Console.Clear();
            Console.Write("Enter a: ");
            float a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("'a' should not be zero!");
                LinearEquation();
            }
            else
            {
                Console.Write("Enter b: ");
                float b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("The equation is {0} * X + {1} = 0", a, b);
                float x = -(b / a);
                Console.WriteLine("X = {0}", x);
            }
        }
        

        // MAIN --------------------------------------------------
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;


            while (true)
            {
                Console.Clear();
                MainMenu();
                int menuEntry = int.Parse(Console.ReadLine());
                Console.Clear();

                // Menu reverse
                if (menuEntry == 1)
                {
                    ReverseNumber();
                }
                // Menu average
                if (menuEntry == 2)
                {
                    AverageSequence();
                }
                // Solves Linear Equation
                if (menuEntry == 3)
                {
                    LinearEquation();
                }
                Console.WriteLine();
                Console.WriteLine("Enter 1 to continue");
                menuEntry = int.Parse(Console.ReadLine());

                if (menuEntry != 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using this software!");
                    return;
                }
            }
        }
    }
}
