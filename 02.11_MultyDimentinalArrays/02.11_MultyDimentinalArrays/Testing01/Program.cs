using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing01
{
    class Program
    {
        static int test = 0;

        static void Proba()
        {
            test++;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Proba();
            }
            Console.WriteLine(test);
        }
    }
}
