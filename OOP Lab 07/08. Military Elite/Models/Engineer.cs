using MilitaryElite.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecializedSoldier, IEngineer
    {
        public List<IRepair> Repairs { get; }

        public Engineer(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (Repair repair in Repairs)
                strBuilder.AppendLine($"\t{repair}");

            return strBuilder.ToString().TrimEnd();
        }
    }
}
