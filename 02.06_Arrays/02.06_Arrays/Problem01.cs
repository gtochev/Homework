﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._06_Arrays
{
    class Problem01
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
