using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>();

            Console.WriteLine("Before adding to items: "+ $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red");
            items.Insert(0, "rellow");

            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("green");
            items.Add("blue");

            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("brown");
            items.Add("white");

            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("lightseagreen");
            items.Add("lightsea");

            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Remove("brown");

            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.RemoveAt(0);  //0. indexteki eleman silinir.

            Console.WriteLine(items.Contains("lightseagreen")); //bu eleman dizide mevcut mu? boolean değer döndürür.
        }
    }
}