using System;
using System.Collections.Generic;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> bagOfProducts;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public double Money
        {
            get => money;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative.");
                money = value;
            }
        }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public IEnumerable<Product> GetProducts() => bagOfProducts;

        public void BuyProduct(Product product)
        {
            if (product.Cost > money)
                throw new ArgumentException($"{name} can't afford {product.Name}");

            Money -= product.Cost;
            bagOfProducts.Add(product);
        }
    }
}
