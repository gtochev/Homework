using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08_CatlanNumbers
{
    class Problem08
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger nFak = 1;
            BigInteger skobiN = 1;

            for (BigInteger i = n + 1; i <= 2 * n; i++)
            {
                nFak *= i;
            }
            for (BigInteger i = 1; i <= n + 1; i++)
            {
                skobiN *= i;
            }
            Console.WriteLine(nFak / skobiN);
        }
    }
}
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).