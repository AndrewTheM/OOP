using MilitaryElite.Models.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public int CodeNumber
        {
            get => codeNumber;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Code number cannot be negative.");
                codeNumber = value;
            }
        }

        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public override string ToString()
            => $"{base.ToString()} Code Number: {CodeNumber}";
    }
}
