using InfernoInfinity.Contracts;

namespace InfernoInfinity.Commands
{
    public abstract class Command : ICommand
    {
        protected string[] Arguments { get; }

        protected Command(string[] arguments)
        {
            Arguments = arguments;
        }

        public abstract string Execute();
    }
}
