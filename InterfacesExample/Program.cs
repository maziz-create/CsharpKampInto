using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        { 

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Add(new CustomerManager());

            Console.WriteLine("--------------------------------------");

            projectManager.Update(new EmployeeManager());
            projectManager.Update(new InternManager());
            projectManager.Update(new CustomerManager());

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("İşçi Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("İşçi Güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
