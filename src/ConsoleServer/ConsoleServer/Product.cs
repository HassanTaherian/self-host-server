using System.Collections.Generic;

namespace ConsoleServer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m },
                new Product { Id = 3, Name = "Headphones", Price = 79.99m },
                new Product { Id = 4, Name = "Camera", Price = 299.99m },
                new Product { Id = 5, Name = "Tablet", Price = 299.99m },
                new Product { Id = 6, Name = "Smartwatch", Price = 199.99m },
                new Product { Id = 7, Name = "Printer", Price = 129.99m },
                new Product { Id = 8, Name = "Gaming Console", Price = 399.99m },
                new Product { Id = 9, Name = "External Hard Drive", Price = 89.99m },
                new Product { Id = 10, Name = "Wireless Mouse", Price = 19.99m }
            };
        }
    }
}
