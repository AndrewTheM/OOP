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

        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            bool CheckCommandName(Type type)
            {
                string commandPortion = type.Name.Split(nameof(Command))[0];
                return type.Namespace == CommandNamespace && commandPortion.ToLower() == commandName;
            }

            var commandType = Assembly.GetExecutingAssembly()
                                      .GetTypes()
                                      .Where(CheckCommandName)
                                      .SingleOrDefault();

            if (commandType == null)
                throw new InvalidOperationException("Invalid command!");

            var commandInstance = Activator.CreateInstance(commandType, data, repository, unitFactory);
            return (IExecutable)commandInstance;
        }
    }
}
