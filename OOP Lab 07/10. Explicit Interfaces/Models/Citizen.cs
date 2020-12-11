using System;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private int age;
        private string country;

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

        public string Country
        {
            get => country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Country cannot be empty.");
                country = value;
            }
        }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        string IPerson.GetName() => Name;

        string IResident.GetName() => $"Mr/Ms/Mrs {Name}";
    }
}
