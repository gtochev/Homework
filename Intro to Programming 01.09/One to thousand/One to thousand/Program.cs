using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_thousand
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 1000)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
