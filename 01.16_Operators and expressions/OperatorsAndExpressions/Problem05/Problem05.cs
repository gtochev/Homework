using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Problem05
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int operaciaEdno = number / 100;
            int operaciaDve = operaciaEdno - 7;
            int operaciaTri = operaciaDve % 10;
            Console.WriteLine(operaciaTri == 0 ? "This number's third digit from right-to-left IS 7: " : "This number's third digit from right-to-left is NOT 7: ");
        }
    }
}
