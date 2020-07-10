using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;

namespace BusinessRuleEngine
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ExecuteBussinessRule();
        }

        public static void ExecuteBussinessRule()
        {
            var products = GetProducts();
            foreach (var product in products)
            {
                var classObj = Factory.GetObject(product.Type);
                classObj.ExecuteRule(product);
            }
            Console.ReadLine();
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>() {
            new Product()
            {
                Type = ProductType.PhysicalProduct,
                Cost = 500,
                Name = "Mug",
                Id = 1
            },
            new Product()
            {
                Type = ProductType.Book,
                Cost = 1000,
                Name = "Theory of Everything",
                Id = 2
            },
             new Product()
            {
                Type = ProductType.MembershipActivate,
                Cost = 2000,
                Id = 3
            },
              new Product()
            {
                Type = ProductType.MembershipUpgrade,
                Cost = 1000,
                Id = 4
            },
              new Product()
            {
                Type = ProductType.Video,
                Name = "Learning to Ski",
                Cost = 500,
                Id = 5
            },
                new Product()
            {
                Type = ProductType.Video,
                Name = "Learning to Dance",
                Cost = 200,
                Id = 6
            }
        };

            return products;
        }
    }
}
