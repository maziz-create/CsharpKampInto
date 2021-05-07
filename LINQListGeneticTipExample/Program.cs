using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQListGeneticTipExample
{
    class Ogrenci
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public double PointAverage { get; set; }
        public Ogrenci(int id, string isim, double notOrtalamasi, string bolum)
        {
            this.Id = id;
            this.FirstName = isim;
            this.Department = bolum;
            this.PointAverage = notOrtalamasi;
        }

        override public string ToString()
        {
            return "name: " + FirstName + "// department" + Department + "// school point average: " + PointAverage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ali = new Ogrenci(1, "mehmet ali", 91.5, "Bilgisayar");
            List<Ogrenci> sinif = new List<Ogrenci>();
            sinif.Add(ali);

            Console.WriteLine($"Doğrudan obje => {ali}");
            Console.WriteLine("\n\n"+$"List üzerinden => {sinif[0]}");
            Console.WriteLine("\n\nCapacity: "+$"{sinif.Capacity}");



            Console.ReadLine();
        }
    }
}
