using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            //---------------------------------------------------------------
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());
            //customerManager.Add(new SqlServerCustomerDal());
            //--------------------------------------------------------------
            //IPerson person1 = new Customer(); //yeni bir müşteri olan insan ürettik.
            //IPerson person2 = new Student();
            
        }
        public void InterfacesInto()
        {
            Student student1 = new Student
            {
                Id = 1,
                FirstName = "Mehmet",
                LastName = "Demo",
                Department = "software"

            };
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Feyza",
                LastName = "Demo",
                Address = "mersinankara"
            };
            PersonManager personManager = new PersonManager();
            personManager.Add(student1);
            personManager.Add(customer1);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.FirstName + " eklendi.");
        //}
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName + " eklendi.");
        //}
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " Eklendi.");
        }

    }
}
