using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Telefon"},
                new Category{CategoryId=2,CategoryName="Bilgisayar"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=2,ProductName="Acer",QuantityPerUnit="32GB Ram",UnitPrice=1134,UnitsInStock=13},
                new Product{ProductId=2,CategoryId=2,ProductName="Dell",QuantityPerUnit="16GB Ram",UnitPrice=1534,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Samsung",QuantityPerUnit="3GB Ram",UnitPrice=1734,UnitsInStock=45},
                new Product{ProductId=4,CategoryId=1,ProductName="Apple",QuantityPerUnit="1GB Ram",UnitPrice=2234,UnitsInStock=1},
            };

            Console.WriteLine("Algoritmik--------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 1500)
                { 
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq--------------------");

            var result = products.Where(p=>p.UnitPrice > 1500);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
