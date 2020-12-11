using System;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        private string id;

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

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id cannot be empty.");
                id = value;
            }
        }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
