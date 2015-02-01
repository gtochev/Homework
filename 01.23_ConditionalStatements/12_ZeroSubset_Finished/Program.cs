using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ZeroSubset_Finished
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers separated by 'space': ");
            string[] numbers = Console.ReadLine().Split(' ');
            int firstNumber = Convert.ToInt16(numbers[0]);
            int secondNumber = Convert.ToInt16(numbers[1]);
            int thirdNumber = Convert.ToInt16(numbers[2]);
            int fourthNumber = Convert.ToInt16(numbers[3]);
            int fifthNumber = Convert.ToInt16(numbers[4]);
            bool subset = false;

            // If the um of two equals zero
            if (firstNumber + secondNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
                subset = true;
            }
            if (firstNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
                subset = true; 
            }
            if (firstNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", firstNumber, fourthNumber);
                subset = true;
            }
            if (firstNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", firstNumber, fifthNumber);
                subset = true;
            }
            if (secondNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
                subset = true;
            }
            if (secondNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", secondNumber, fourthNumber);
                subset = true;
            }
            if (secondNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", secondNumber, fifthNumber);
                subset = true;
            }
            if (thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", thirdNumber, fourthNumber);
                subset = true;
            }
            if (thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", thirdNumber, fifthNumber);
                subset = true;
            }
            if (fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", fourthNumber, fifthNumber);
                subset = true;
            }

            // If the sum of three equals zero
            if (firstNumber + secondNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
                subset = true;
            }
            if (firstNumber + secondNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fourthNumber);
                subset = true;
            }
            if (firstNumber + secondNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fifthNumber);
                subset = true;
            }
            if (firstNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourthNumber);
                subset = true;
            }
            if (firstNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fifthNumber);
                subset = true;
            }
            if (firstNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            if (secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourthNumber);
                subset = true;
            }
            if (secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            if (thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            // If the sum of four equals zero
            if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
                subset = true;
            }
            if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fifthNumber);
                subset = true;
            }
            if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNumber, thirdNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            // Sum of five
            if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
                subset = true;
            }
            if (subset == false)
	        {
		        Console.WriteLine("no zero subset");
	        }
            //-----------
        }
    }
}
