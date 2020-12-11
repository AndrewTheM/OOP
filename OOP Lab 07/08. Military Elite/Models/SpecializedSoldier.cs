using MilitaryElite.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Linq;

namespace MilitaryElite.Models
{
    public abstract class SpecializedSoldier : Private, ISpecializedSoldier
    {
        private SoldierCorps corps;

        public string Corps
        {
            get => corps.ToString();
            set
            {
                if (!Enum.GetNames(typeof(SoldierCorps)).Contains(value))
                    throw new ArgumentException("Invalid corps.");
                corps = Enum.Parse<SoldierCorps>(value);
            }
        }

        public SpecializedSoldier(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public override string ToString()
            => $"{base.ToString()} Corps: {Corps}";
    }
}
