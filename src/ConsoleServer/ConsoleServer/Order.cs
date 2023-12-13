using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleServer
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Products = new List<Product>
                    {
                        new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                        new Product { Id = 2, Name = "Smartphone", Price = 499.99m }
                    },
                    TotalPrice = 1499.98m
                },
                new Order
                {
                    Id = 2,
                    Products = new List<Product>
                    {
                        new Product { Id = 3, Name = "Headphones", Price = 79.99m },
                        new Product { Id = 4, Name = "Camera", Price = 299.99m },
                        new Product { Id = 5, Name = "Tablet", Price = 299.99m }
                    },
                    TotalPrice = 679.97m
                },
                new Order
                {
                    Id = 3,
                    Products = new List<Product>
                    {
                        new Product { Id = 6, Name = "Smartwatch", Price = 199.99m },
                        new Product { Id = 7, Name = "Printer", Price = 129.99m },
                        new Product { Id = 8, Name = "Gaming Console", Price = 399.99m }
                    },
                    TotalPrice = 729.97m
                }
            };
        }
    }
}
