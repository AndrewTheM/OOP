using System;

namespace WorkForce.Models
{
    public abstract class Employee
    {
        private string name;
        private int workHoursPerWeek;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Employee's name cannot be empty.");
                name = value;
            }
        }

        public int WorkHoursPerWeek
        {
            get => workHoursPerWeek;
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("Employee's work hours per week have to be between 1 and 100.");
                workHoursPerWeek = value;
            }
        }

        protected Employee(string name, int workHoursPerWeek)
        {
            Name = name;
            WorkHoursPerWeek = workHoursPerWeek;
        }
    }
}
