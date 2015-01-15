using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Problem10
    {
        static void Main(string[] args)
        {
            string firstName;
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            string lastName;
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            int age;
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            if (age <= 100 && age >= 0)
            {
                Char gender;
                Console.Write("Enter Gender(M or F): ");
                gender = Console.ReadLine().Trim()[0];
                if (gender == 'M' || gender == 'F')
                {
                    Console.Write("Enter Personal ID: ");
                    long personalID = long.Parse(Console.ReadLine());
                    Console.Write("Enter Employee ID: ");
                    int employeeID = int.Parse(Console.ReadLine());
                    if (employeeID >= 27560000 && employeeID <=27569999)
                    {
                        Console.WriteLine("Your complete Data is: " + "\n");
                        Console.WriteLine("Full Name: " + firstName + " " + lastName);
                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("Gender: " + gender);
                        Console.WriteLine("PersonalID: " + personalID);
                        Console.WriteLine("Employee ID: " + employeeID);
                    }
                    else
                        Console.WriteLine("Wrong Employee ID input!");
                    
                }
                else
                {
                    Console.WriteLine("Wrong gender input!");
                }
            }
            else
            {
                Console.WriteLine("Wrong age!");
            }
        }
    }
}
