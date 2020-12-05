using BarracksWars.Contracts;
using BarracksWars.Core.Attributes;
using BarracksWars.Core.Helpers;

namespace BarracksWars.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data) : base(data)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
        {
            string unitType = Data[1];
            var unit = unitFactory.CreateUnit(unitType);

            repository.AddUnit(unit);
            return $"{unitType} added!";
        }
    }
}
