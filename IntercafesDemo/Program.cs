using System;

namespace IntercafesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
        }
    }
    interface IWorker
    {
        public void Work();
    }
    interface IEat
    {
        public void Eat();
    }
    interface ISalary
    {
        public void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat() { }
        public void GetSalary() { }
        public void Work() { }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat() { }
        public void GetSalary() { }
        public void Work() { }
    }
    class Robot : IWorker
    {
        public void Work() { }
    }
}
