using System;

namespace PersonInterface.Models
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

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

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
