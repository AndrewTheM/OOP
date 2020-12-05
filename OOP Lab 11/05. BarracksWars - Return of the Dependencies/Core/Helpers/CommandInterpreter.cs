using BarracksWars.Contracts;
using BarracksWars.Core.Commands;
using System;
using System.Linq;
using System.Reflection;

namespace BarracksWars.Core.Helpers
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandNamespace = "BarracksWars.Core.Commands";

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            bool IsNeededCommand(Type type)
            {
                if (!type.Name.EndsWith(nameof(Command)))
                    return false;

                string commandPortion = type.Name.Split(nameof(Command))[0];
                return type.Namespace == CommandNamespace &&
                        commandPortion.ToLower() == commandName.ToLower();
            }

            var commandType = Assembly.GetExecutingAssembly()
                                      .GetTypes()
                                      .Where(IsNeededCommand)
                                      .SingleOrDefault();

            if (commandType == null)
                throw new InvalidOperationException("Invalid command!");

            var commandInstance = Activator.CreateInstance(commandType, new object[] { data });
            return (IExecutable)commandInstance;
        }
    }
}
