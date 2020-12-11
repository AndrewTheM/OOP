using BirthdayCelebrations.Models.Interfaces;
using System;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable, INameable
    {
        private string name;
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

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
