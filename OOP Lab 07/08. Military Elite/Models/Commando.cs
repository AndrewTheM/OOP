using MilitaryElite.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecializedSoldier, ICommando
    {
        public List<IMission> Missions { get; }

        public Commando(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (Mission mission in Missions)
                strBuilder.AppendLine($"\t{mission}");

            return strBuilder.ToString().TrimEnd();
        }
    }
}
