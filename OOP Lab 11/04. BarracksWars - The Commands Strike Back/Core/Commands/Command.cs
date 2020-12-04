using BarracksWars.Contracts;

namespace BarracksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        protected string[] Data { get; }

        protected IRepository Repository { get; }

        protected IUnitFactory UnitFactory { get; }

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            Data = data;
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public abstract string Execute();
    }
}
