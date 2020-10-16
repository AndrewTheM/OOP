using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private static readonly Dictionary<string, double> types;

        static Topping()
        {
            types = new Dictionary<string, double>
            {
                ["Meat"] = 1.2,
                ["Veggies"] = 0.8,
                ["Cheese"] = 1.1,
                ["Sauce"] = 0.9
            };
        }

        private string type;
        private int weight;

        private string Type
        {
            get => type;
            set
            {
                if (!types.ContainsKey(value))
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                type = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                weight = value;
            }
        }

        public double CaloriesPerGram
            => types[Type] * 2;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }
    }
}
