using System;
using System.Text;

namespace Mankind.Models
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value <= 10)
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
                weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                workHoursPerDay = value;
            }
        }

        public decimal SalaryPerHour => WeekSalary / (WorkHoursPerDay * 5);

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .Append(base.ToString())
                .AppendLine($"Week Salary: {WeekSalary:0.00}")
                .AppendLine($"Hours per day: {WorkHoursPerDay}")
                .AppendLine($"Salary per hour: {SalaryPerHour:0.00}");

            return strBuilder.ToString();
        }
    }
}
