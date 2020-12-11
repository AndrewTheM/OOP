using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private static readonly Dictionary<string, double> flourTypes;
        private static readonly Dictionary<string, double> bakingTechniques;

        static Dough()
        {
            flourTypes = new Dictionary<string, double>
            {
                ["White"] = 1.5,
                ["Wholegrain"] = 1.0
            };

            bakingTechniques = new Dictionary<string, double>
            {
                ["Crispy"] = 0.9,
                ["Chewy"] = 1.1,
                ["Homemade"] = 1.0
            };
        }

        private string type;
        private string technique;
        private int weight;

        private string Type
        {
            get => type;
            set
            {
                if (!flourTypes.ContainsKey(value))
                    throw new ArgumentException("Invalid type of dough.");
                type = value;
            }
        }

        private string Technique
        {
            get => technique;
            set
            {
                if (!bakingTechniques.ContainsKey(value))
                    throw new ArgumentException("Invalid baking technique.");
                technique = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value;
            }
        }

        public double CaloriesPerGram
            => flourTypes[Type] * bakingTechniques[Technique] * 2;

        public Dough(string type, string technique, int weight)
        {
            Type = type;
            Technique = technique;
            Weight = weight;
        }
    }
}
