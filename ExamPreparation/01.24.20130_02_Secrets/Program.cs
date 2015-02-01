using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._24._20130_02_Secrets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string number = Console.ReadLine();

            BigInteger specialSum = 0;
            BigInteger currentNumber = 0;
            BigInteger counter = 1;
            BigInteger lastNumber = 0;

            // Finding Special Sum
            for (int i = number.Length - 1; i >= 0; i--)
            {
                currentNumber = (Convert.ToInt16(number[i]) - '0');
                if (counter % 2 == 1)
                {

                    specialSum += currentNumber * (counter * counter);
                }
                if (counter % 2 == 0)
                {
                    specialSum += currentNumber * currentNumber * counter;
                }
                counter++;
            }
            // First output
            Console.WriteLine(specialSum);

            // Finding Alpha Sequence
            lastNumber = specialSum % 10;
            BigInteger numberR = specialSum % 26;
            char abc = 'A';
            if (lastNumber == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                
                for (int i = 0; i < numberR; i++)
                {
                    abc++;
                }


                for (int i = 0; i < lastNumber; i++)
                {
                    Console.Write(abc);
                    abc++;

                    if (abc > 'Z')
                    {
                        abc = 'A';
                    }
                }
            }
        }
    }
}
