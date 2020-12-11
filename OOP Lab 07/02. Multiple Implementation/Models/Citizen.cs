using System;

namespace MultipleImplementation.Models
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        private string id;
        private string birthdate;

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

        public string Birthdate
        {
            get => birthdate;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Birthdate cannot be empty.");
                birthdate = value;
            }
        }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
