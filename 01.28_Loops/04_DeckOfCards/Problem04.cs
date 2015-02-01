using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DeckOfCards
{
    class Problem04
    {
        static void Main(string[] args)
        {
            string cards = "JQKA";

            for (int j = 2; j <= 9; j++)
            {
                Console.Write("{0} of spades, ", j);
                Console.Write("{0} of clubs, ", j);
                Console.Write("{0} of hearts, ", j);
                Console.WriteLine("{0} of diamonds", j);
            }

            for (int k = 0; k < cards.Length; k++)
            {
                Console.Write("{0} of spades, ", cards[k]);
                Console.Write("{0} of clubs, ", cards[k]);
                Console.Write("{0} of hearts, ", cards[k]);
                Console.WriteLine("{0} of diamonds, ", cards[k]);
            }
        }
    }
}
