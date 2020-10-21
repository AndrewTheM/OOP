using System;
using System.Text;

namespace Mankind.Models
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("Invalid faculty number!");
                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .Append(base.ToString())
                .AppendLine($"Faculty number: {FacultyNumber}");

            return strBuilder.ToString();
        }
    }
}
