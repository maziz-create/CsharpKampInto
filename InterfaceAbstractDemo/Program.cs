using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());

            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,6,12), FirstName="Polat", LastName="Alemdar", NationalityId="12345678910" });

            Console.ReadLine();
        }
    }
    
}