using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calculate
{
    class Problem05
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double factorial = 1;
            double delenie = X;
            double sum = 1;

            for (int i = 1; i <= N; i++)
            {

                factorial *= i;
                sum += factorial / delenie;
                delenie *= X;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
