using MilitaryElite.Models.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        public string Id
        {
            get => id;
            set => id = ValidateString(value, nameof(Id));
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = ValidateString(value, "First name");
        }

        public string LastName
        {
            get => lastName;
            set => lastName = ValidateString(value, "Last name");
        }

        public Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        protected virtual string ValidateString(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{propName} cannot be empty.");
            return value;
        }

        public override string ToString()
            => $"Name: {FirstName} {LastName} Id: {Id}";
    }
}
