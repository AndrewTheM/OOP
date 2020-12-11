using System;

namespace PersonInheritance.Models
{
    public class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get => name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                name = value;
            }
        }

        public virtual int Age
        {
            get => age;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Age must be positive!");
                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
            => $"Name: {Name}, Age: {Age}";
    }
}
