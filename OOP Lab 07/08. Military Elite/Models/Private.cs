using MilitaryElite.Models.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        private double salary;

        public double Salary
        {
            get => salary;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Salary cannot be negative or zero");
                salary = value;
            }
        }

        public Private(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
            => $"{base.ToString()} Salary: {Salary:0.00}";
    }
}
