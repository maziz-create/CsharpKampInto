using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Mehmet Aziz";

            Console.WriteLine(customer1.FirstName);
        }
    }
}
