using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2013_02_Nightmare
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char currentChar;
            int result = 0;
            int counter = 0;
            int number = 0;

            for (int i = 1; i < text.Length; i = i + 2)
            {
                currentChar = text[i];
                if (text[i] > 47 && text[i] < 58)
                {

                    number = int.Parse(currentChar.ToString());
                    result = result + number;
                }
                counter++;
            }
            Console.Write(counter + " ");
            Console.WriteLine(result);
        }
    }
}
