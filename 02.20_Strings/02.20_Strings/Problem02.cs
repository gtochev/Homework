﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._20_Strings
{
    class Problem02
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strRev = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strRev += str[i];
            }
            Console.WriteLine(strRev);
        }
    }
}
