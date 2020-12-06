using InfernoInfinity.Contracts.Narrow;

namespace InfernoInfinity.Commands
{
    public abstract class Command : ICommand
    {
        protected string[] Arguments { get; }

        protected Command(string[] arguments)
        {
            Arguments = arguments;
        }

        public virtual string Execute()
            => string.Empty;
    }
}
