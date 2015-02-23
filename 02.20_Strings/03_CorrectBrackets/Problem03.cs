using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CorrectBrackets
{
    class Problem03
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int leftBracket = 0;
            int rightBracket = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    leftBracket++;
                }
                if (str[i] == ')')
                {
                    rightBracket++;
                }
                if (leftBracket < rightBracket)
                {
                    Console.WriteLine("Wrongly put brackets");
                    return;
                }
            }
            if (leftBracket != rightBracket)
            {
                Console.WriteLine("Wrongly put brackets");
            }
            else
            {
                Console.WriteLine("Brackets were put correctly" );
            }
        }
    }
}
