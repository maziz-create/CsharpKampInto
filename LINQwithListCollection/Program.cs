using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQwithListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>();
            items.Add("aQua");
            items.Add("RusT");
            items.Add("yEllow");
            items.Add("rEd");

            Console.WriteLine("items contains");
            foreach (var item in items)
            {
                Console.WriteLine($"{item}");
            }

            var startWithR = 
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            Console.WriteLine("results of startWithR");
            foreach (var item in startWithR)
            {
                Console.WriteLine($"{item}");
            }

            items.Add("rUby");
            items.Add("SaFRoN");

            Console.WriteLine("results of startWithR");
            foreach (var item in startWithR)
            {
                Console.WriteLine($"{item}");
            }


            Console.ReadLine();
        } 
    }
}
