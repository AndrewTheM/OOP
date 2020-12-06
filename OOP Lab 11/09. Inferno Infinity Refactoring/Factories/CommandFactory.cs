using InfernoInfinity.Commands;
using InfernoInfinity.Contracts.Narrow;
using System;
using System.Linq;
using System.Reflection;

namespace InfernoInfinity.Factories
{
    public class CommandFactory : ReflectiveFactory<ICommand>
    {
        public CommandFactory()
            : base("InfernoInfinity.Commands")
        {
        }

        public override ICommand Create(string type, params object[] parameters)
        {
            try
            {
                bool IsNeededCommand(Type targetType)
                {
                    if (!targetType.Name.EndsWith(nameof(Command)))
                        return false;

                    string commandPortion = targetType.Name.Split(nameof(Command))[0];
                    return targetType.Namespace == targetNamespace
                           && commandPortion.ToLower() == type.ToLower();
                }

                var targetType = Assembly.GetExecutingAssembly()
                                 .GetTypes()
                                 .Where(IsNeededCommand)
                                 .Single();

                var instance = Activator.CreateInstance(targetType, parameters);
                return (ICommand)instance;
            }
            catch
            {
                throw new InvalidOperationException("Invalid command.");
            }
        }
    }
}
