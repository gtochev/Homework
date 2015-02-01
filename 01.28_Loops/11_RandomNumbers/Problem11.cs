using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RandomNumbers
{
    class Problem11
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int random = 0;

            for (int i = 0; i < n; i++)
            {
                random = rnd.Next(min, max);
                Console.Write("{0} ", random);
            }
        }
    }
}
