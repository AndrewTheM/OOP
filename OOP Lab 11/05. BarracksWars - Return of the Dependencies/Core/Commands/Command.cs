using BarracksWars.Contracts;

namespace BarracksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        protected string[] Data { get; }

        protected Command(string[] data)
        {
            Data = data;
        }

        public abstract string Execute();
    }
}
