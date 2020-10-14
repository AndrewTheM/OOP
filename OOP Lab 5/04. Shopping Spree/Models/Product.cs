using System;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private double cost;

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

        public double Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Cost cannot be negative.");
                cost = value;
            }
        }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
