using System;

namespace KingsGambit.Models.Base
{
    public abstract class Person
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Person's name cannot be empty.");
                name = value;
            }
        }

        protected Person(string name)
        {
            Name = name;
        }
    }
}
