using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IndexOfLetters
{
    class Problem12
    {
        static void Main(string[] args)
        {
            int[] alphabet = new int[26];

            for (int i = 'A'; i <= 'Z'; i++)
            {
                alphabet[i - 65] = i;
            }

            Console.WriteLine("Enter a word in upper case:");
            string word = Console.ReadLine();

            foreach (var item in word)
            {

                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (item == alphabet[i])
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }

        }
    }
}
