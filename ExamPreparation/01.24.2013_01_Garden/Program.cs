using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._24._2013_01_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());
            decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());
            decimal potatoSeeds = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());
            decimal carrotSeeds = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());
            decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
            decimal cabbageArea = decimal.Parse(Console.ReadLine());
            decimal beenSeeds = decimal.Parse(Console.ReadLine());
            decimal leftArea = 0;
            decimal totalPrice = 0;


            // Solution logic
            leftArea = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
            totalPrice = tomatoSeeds * 0.50m + cucumberSeeds * 0.40m + potatoSeeds * 0.25m + carrotSeeds * 0.60m + cabbageSeeds * 0.30m + beenSeeds * 0.40m;


            // Output
            Console.WriteLine("Total costs: {0}", totalPrice);
            if (leftArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (leftArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (leftArea > 0)
            {
                Console.WriteLine("Beans area: {0}", leftArea);
            }

        }
    }
}
