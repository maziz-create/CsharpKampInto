using System;
using System.Linq;

namespace LinqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //created an integer array
            var values = new[] {2,9,5,0,3,7,1,4,8,5 };

            // display original values
            Console.WriteLine("Orijinal Dizi:\n");
            foreach (var element in values)
            {
                Console.Write($"{element}\t");
            }

            FilteredArray(values);
            SortedArray(values);

            var employees = new[]
            {
                new Employee(1,"Jason","Red", 5000),
                new Employee(2,"Ashley","Green", 7600),
                new Employee(3,"Matthew","Indigo", 3587),
                new Employee(4,"James","Indigo", 4700),
                new Employee(5,"Luke","Indigo", 6200),
                new Employee(6,"Jason","Blue", 3200),
                new Employee(7,"Wendy","Brown", 4236)
            };

            Console.WriteLine("\nObject Array:\n");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nEmployees earning in the range "+ $"{4000:C}-{6000:C} per moth:\n");
            var between4k6k =
                from e in employees
                where e.mothlySalary >= 4000 && e.mothlySalary <= 6000
                select e;
            foreach (var item in between4k6k)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFirst employee when sorted by name:\n");

            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("\nnameSorted dizisi boş döndü!\n");
                throw new Exception("It's null array");
            }

            Console.WriteLine("\nUnique employee last names\n");

            var lastNames =
                from e in employees
                orderby e.LastName
                select e.LastName;

            foreach (var item in lastNames.Distinct())
            {
                Console.Write(item+ "\t");
            }

            Console.WriteLine("\n\nNames only:\n");

            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        } 
        public static void FilteredArray(int[] values)
        {
            Console.WriteLine("\n4ten büyükleri filtreleyen dizi\n");
            var filtered =
                from value in values
                where value > 4
                select value;
            foreach (var item in filtered)
            {
                Console.Write($"{item}\t");
            }
        }
        public static void SortedArray(int[] values)
        {
            Console.WriteLine("\nKüçükten büyüğe sıralanmış dizi\n");
            var sorted =
                from value in values
                orderby value
                select value;
            foreach (var item in sorted)
            {
                Console.Write($"{item}\t");
            }
        }
        
    }
}
