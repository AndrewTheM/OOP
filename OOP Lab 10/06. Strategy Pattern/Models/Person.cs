using System;

namespace StrategyPattern.Models
{
    public class Person : IComparable<Person>
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
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (other == null)
                throw new ArgumentNullException();

            if (Name == other.Name)
                return Age.CompareTo(other.Age);
            else
                return Name.CompareTo(other.Name);
        }

        public override string ToString()
            => $"{Name} {Age}";
    }
}
