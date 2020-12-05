using BarracksWars.Contracts;
using BarracksWars.Core.Attributes;
using BarracksWars.Core.Helpers;

namespace BarracksWars.Core.Commands
{
    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
            => repository.Statistics;
    }
}
