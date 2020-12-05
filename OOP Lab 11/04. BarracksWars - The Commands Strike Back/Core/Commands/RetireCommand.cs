using BarracksWars.Contracts;

namespace BarracksWars.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            Repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
        }
    }
}
