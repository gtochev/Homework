using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07_Calculate
{
    class Problem07
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nKFak = 1;
            BigInteger nMinusK = n - k;
            BigInteger vSkobi = 1;
            BigInteger result = 1;

            for (int i = k + 1; i <= n; i++)
            {
                nKFak *= i;
            }
            for (int i = 1; i <= nMinusK; i++)
            {
                vSkobi *= i;
            }
            result = nKFak / vSkobi;
            Console.WriteLine(result);
        }
    }
}

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.