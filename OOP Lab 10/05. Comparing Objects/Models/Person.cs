using System;

namespace ComparingObjects.Models
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name
        {
            get => name;
            set => name = ValidateString(value, nameof(Name));
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

        public string Town
        {
            get => town;
            set => town = ValidateString(value, nameof(Town));
        }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        private static string ValidateString(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{propName} cannot be empty.");
            return value;
        }

        public int CompareTo(Person other)
        {
            if (other == null)
                throw new ArgumentNullException();

            if (Name == other.Name)
            {
                if (Age == other.Age)
                    return Town.CompareTo(other.Town);
                else
                    return Age.CompareTo(other.Age);
            }
            else
                return Name.CompareTo(other.Name);
        }
    }
}
