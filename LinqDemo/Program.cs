using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Lenovo Dizüstü Bilgisayar", UnitPrice=7500, UnitsInStock=55},
                new Product{ProductId=2, CategoryId=1, ProductName="Huawei Dizüstü Bilgisayar", UnitPrice=7100, UnitsInStock=32},
                new Product{ProductId=3, CategoryId=2, ProductName="Samsung Akıllı Telefon", UnitPrice=4900, UnitsInStock=140},
                new Product{ProductId=4, CategoryId=2, ProductName="LG Akıllı Telefon", UnitPrice=4350, UnitsInStock=700}
            };

            
            GetProducts(products);

            GetProductswithLinq(products);

        }

        //ürünleri, kategorileri nasıl listeleriz? yöntem-1 => foreach döngüsü
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        //ürünleri, kategorileri nasıl listeleriz? yöntem-2 => Linq ile listeleme
        static List<Product> GetProductswithLinq(List<Product> products)
        {
            return products.Where(p=>p.UnitPrice>5000).ToList();
            
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
