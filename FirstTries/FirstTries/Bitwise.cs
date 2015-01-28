using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTries
{
    class Bitwise
    {
        static void Main(string[] args)
        {
            //Replacing 0 with 1 in a    bit!
            //bitVariable |= (1 << bitposition);

            //Replacing 1 with 0 in a bit!
            //bitVariable ^= (1 << bitposition);
            //OR
            //bitVariable &= ~(1 << bitposition);
            
            int number = int.Parse(Console.ReadLine());
            string result = Convert.ToString(number, 2);
            Console.WriteLine(result);

            int novaEdno = 0;
            int novaDve = 0;

            for (int i = 0; i < result.Length; i++)
            {
                novaEdno = 0;
                novaEdno = 1 << i;
                novaDve = novaEdno ^ novaDve;
                                
            }
            result = Convert.ToString(novaDve, 2);
            Console.WriteLine(result);

            number = number ^ novaDve;
            result = Convert.ToString(number, 2).PadLeft(result.Length, '0');
            Console.WriteLine(result);

            //number 
            //Console.WriteLine(number);

        }
    }
}
