using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._23._2013_01_CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            decimal nOne = decimal.Parse(Console.ReadLine());
            decimal nTwo = decimal.Parse(Console.ReadLine());
            decimal nThree = decimal.Parse(Console.ReadLine());
            decimal nFour = decimal.Parse(Console.ReadLine());
            decimal nFive = decimal.Parse(Console.ReadLine());
            decimal moneyPut = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            decimal moneyInMachine = 0;

            decimal restoToGive = 0.0m;

            // Money in machine
            moneyInMachine = nOne * 0.05m + nTwo * 0.10m + nThree * 0.20m + nFour * 0.50m + nFive * 1.00m;
            restoToGive = moneyPut - price;

            // If not enough in machine
            if (restoToGive > moneyInMachine)
            {
                Console.WriteLine("No {0:F2}", restoToGive - moneyInMachine);
            }
            // If not enough put in macine
            if (moneyPut < price)
            {
                Console.WriteLine("More {0:F2}", price - moneyPut);
            }

            // Solution
            // Damn
            while ((restoToGive >= 1) && (nFive > 0))
            {
                restoToGive -= 1;
                nFive--;
            }
            while ((restoToGive >= 0.50m ) && (nFour > 0))
            {
                restoToGive -= 0.50m;
                nFour--;
            }
            while ((restoToGive >= 0.20m) && (nThree > 0))
            {
                restoToGive -= 0.20m;
                nThree--;
            }
            while ((restoToGive >= 0.10m) && (nTwo > 0))
            {
                restoToGive -= 0.10m;
                nTwo--;
            }
            while ((restoToGive >= 0.05m) && (nOne > 0))
            {
                restoToGive -= 0.05m;
                nOne--;
            }

            // Output when transaction is completed
            if (restoToGive == 0)
            {
                moneyInMachine = nOne * 0.05m + nTwo * 0.10m + nThree * 0.20m + nFour * 0.50m + nFive * 1.00m;
                Console.WriteLine("Yes {0:F2}", moneyInMachine);
            }

            

            // Output

        }
    }
}
