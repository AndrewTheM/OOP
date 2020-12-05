using BarracksWars.Contracts;
using BarracksWars.Core.Attributes;
using BarracksWars.Core.Helpers;

namespace BarracksWars.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
        {
            string unitType = Data[1];
            repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
        }
    }
}
