using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Problem02
    {
        static void Main(string[] args)
        {
            string complanyName = Console.ReadLine();
            string complanyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string phoneManager = Console.ReadLine();
            Console.WriteLine(complanyName);
            Console.WriteLine("Address: " + complanyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("(no fax)");
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("{0} {1} (age: {2}, tel. {3})", firstName, lastName, age, phoneManager);
        }
    }
}
