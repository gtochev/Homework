using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ZeroSubset
{
    class Problem12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers separated by 'space': ");
            string[] numbers = Console.ReadLine().Split(' ');
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int fifthNumber = 0;
            bool isZero = false;
            string test = string.Empty;

            // If sum of two equals zero
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNumber = Convert.ToInt16(numbers[i]);
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    secondNumber = Convert.ToInt16(numbers[k]);
                    if (firstNumber + secondNumber == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
                        //test = Convert.ToString(firstNumber + " + " + secondNumber + " = 0");
                        isZero = true;
                    }
                }
            }
            // If the sum of three equals zero
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNumber = Convert.ToInt16(numbers[i]);
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    secondNumber = Convert.ToInt16(numbers[k]);
                    for (int l = k + 1; l < numbers.Length; l++)
                    {
                        thirdNumber = Convert.ToInt16(numbers[l]);
                        if (firstNumber + secondNumber + thirdNumber == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
                            isZero = true;
                        }
                    }
                }
            }
            // If the sum of four equals zero
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNumber = Convert.ToInt16(numbers[i]);
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    secondNumber = Convert.ToInt16(numbers[k]);
                    for (int l = k + 1; l < numbers.Length; l++)
                    {
                        thirdNumber = Convert.ToInt16(numbers[l]);
                        for (int m = l + 1; m < numbers.Length; m++)
                        {
                            fourthNumber = Convert.ToInt16(numbers[m]);
                            if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
                                isZero = true;
                            }
                            m--;
                        }
                    }
                }
            }
            // If the sum of five numbers equals zero
            firstNumber = Convert.ToInt16(numbers[0]);
            secondNumber = Convert.ToInt16(numbers[1]);
            thirdNumber = Convert.ToInt16(numbers[2]);
            fourthNumber = Convert.ToInt16(numbers[3]);
            fifthNumber = Convert.ToInt16(numbers[4]);
            if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
                isZero = true;
            }
            //if (isZero == false)
            //{
            //    Console.WriteLine("no zero subset");
            //}
        }
    }
}
