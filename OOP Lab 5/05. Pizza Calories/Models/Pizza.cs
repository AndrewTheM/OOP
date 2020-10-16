using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        public int NumberOfToppings => toppings.Count;

        public double TotalCalories
        {
            get
            {
                double total = dough.CaloriesPerGram * dough.Weight;

                foreach (var topping in toppings)
                    total += topping.CaloriesPerGram * topping.Weight;

                return total;
            }
        }

        public Dough Dough
        {
            set => dough = value;
        }

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            if (NumberOfToppings == 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            toppings.Add(topping);
        }

        public override string ToString()
            => $"{Name} - {TotalCalories:0.00} Calories";
    }
}
