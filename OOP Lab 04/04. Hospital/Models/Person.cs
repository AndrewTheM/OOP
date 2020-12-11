using System;

namespace HospitalManagement.Models
{
    public abstract class Person
    {
        protected string name;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length <= 1 || value.Length > 20)
                    throw new ArgumentException("Name must be 2-20 characters");
                name = value;
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
            => Name;
    }
}
