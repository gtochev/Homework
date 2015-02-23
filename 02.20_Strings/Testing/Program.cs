using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            string numToStr = string.Empty;
            int counter = 0;

            foreach (var item in numbers)
            {

                numToStr += numbers[counter];
                counter++;
            }
            Console.WriteLine(numToStr);
        }
    }
}
