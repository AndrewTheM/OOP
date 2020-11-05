using System.Collections.Generic;

namespace LinqProblems.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int GroupNumber { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public List<int> Marks { get; }

        public int FacultyNumber { get; set; }

        protected Student()
        {
            Marks = new List<int>();
        }

        public Student(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(int facultyNumber) : this()
        {
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
            => $"{FirstName} {LastName}";
    }
}
