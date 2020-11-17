using System;

namespace WorkForce.Models
{
    public class Job
    {
        private string name;
        private int hoursRequired;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Job's name cannot be empty.");
                name = value;
            }
        }

        public int HoursRequired
        {
            get => hoursRequired;
            set
            {
                if (value < 1 || value > 1000)
                {
                    if (hoursRequired > 0)
                    {
                        hoursRequired = 0;
                        OnCompletion();
                    }
                    else
                        throw new ArgumentException("Job's hours of work required have to be between 1 and 1000.");
                }
                else
                    hoursRequired = value;
            }
        }

        public Employee AssignedEmployee { get; }

        public Job(string name, int hoursRequired, Employee employee)
        {
            Name = name;
            HoursRequired = hoursRequired;
            AssignedEmployee = employee;
        }

        public void Update()
        {
            HoursRequired -= AssignedEmployee.WorkHoursPerWeek;
        }

        public event EventHandler Completed;

        protected virtual void OnCompletion()
        {
            Console.WriteLine($"Job {Name} is done!");
            Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}
