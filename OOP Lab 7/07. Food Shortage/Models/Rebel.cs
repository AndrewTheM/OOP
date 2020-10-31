using FoodShortage.Models.Interfaces;
using System;

namespace FoodShortage.Models
{
    public class Rebel : IPerson, IBuyer
    {
        private string name;
        private int age;
        private string group;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (age < 0)
                    throw new ArgumentException("Age cannot be negative.");
                age = value;
            }
        }

        public string Group
        {
            get => group;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Group cannot be empty.");
                group = value;
            }
        }

        public int Food { get; private set; }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public void BuyFood() => Food += 5;
    }
}
