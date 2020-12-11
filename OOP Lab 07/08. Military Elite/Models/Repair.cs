using MilitaryElite.Models.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;

        public string PartName
        {
            get => partName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Part name cannot be empty.");
                partName = value;
            }
        }

        public int HoursWorked
        {
            get => hoursWorked;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Hours worked cannot be negative.");
                hoursWorked = value;
            }
        }

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public override string ToString()
            => $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}
