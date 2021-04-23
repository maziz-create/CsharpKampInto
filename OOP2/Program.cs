using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Individual Customer
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Mehmet Aziz";
            customer1.LastName = "Algüllü";
            customer1.IdentityNumber = "12345678910";

            //Corporate Customer
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Yazilimci.io";
            customer2.TaxNumber = "1234567890";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            
        }
    }
}
