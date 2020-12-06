using System;

namespace InfernoInfinity.Commands
{
    public class EndCommand : Command
    {
        public EndCommand(string[] arguments) : base(arguments)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return base.Execute();
        }
    }
}
