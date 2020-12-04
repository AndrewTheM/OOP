using BarracksWars.Contracts;

namespace BarracksWars.Core.Commands
{
    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
            => Repository.Statistics;
    }
}
