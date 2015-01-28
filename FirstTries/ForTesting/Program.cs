using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumForPrint = 0;
            int first = 19;
            int tildaP = 12;
            int tochkiP = 25;


            sumForPrint = ((first ^ tildaP) & tochkiP);
            Console.WriteLine(sumForPrint);
        }
    }
}
