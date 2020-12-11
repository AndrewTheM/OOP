using System;
using System.Text;

namespace Mankind.Models
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set => firstName = ValidateName(value, nameof(firstName), 4);
        }

        public string LastName
        {
            get => lastName;
            set => lastName = ValidateName(value, nameof(lastName), 3);
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private string ValidateName(string value, string argName, int minLength)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < minLength)
                throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {argName}");
            if (!char.IsUpper(value[0]))
                throw new ArgumentException($"Expected upper case letter! Argument: {argName}");
            return value;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine($"First Name: {FirstName}")
                .AppendLine($"Last Name: {LastName}");

            return strBuilder.ToString();
        }
    }
}
