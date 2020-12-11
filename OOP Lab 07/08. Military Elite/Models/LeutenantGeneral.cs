using MilitaryElite.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public List<IPrivate> Privates { get; }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (Private priv in Privates)
                strBuilder.AppendLine($"\t{priv}");

            return strBuilder.ToString().TrimEnd();
        }
    }
}
