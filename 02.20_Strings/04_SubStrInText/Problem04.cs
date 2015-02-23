
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SubStrInText
{
    class Problem04
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to be searched: ");
            string str = Console.ReadLine();
            Console.Write("Enter what should be searched for: ");
            string strSearch = Console.ReadLine();
            int repeatedStr = 0;
            int found = -1;

            while (true)
            {
                found = str.IndexOf(strSearch, found + 1);
                if (found < 0)
                {
                    break;
                }
                repeatedStr++;
                
            }
            Console.WriteLine(repeatedStr);
        }
    }
}
