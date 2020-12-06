using InfernoInfinity.Contracts.Generic;
using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Contracts.Wide;
using InfernoInfinity.Helpers;
using System;

namespace InfernoInfinity
{
    public class Engine : IEngine
    {
        private IReader inputReader;

        private IWriter outputWriter;

        private IReflectiveFactory<ICommand> commandFactory;

        public Engine()
        {
            Injector.Instance.PerformInjection(this);
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string line = inputReader.Read();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var arguments = line.Split(';');
                    string commandName = arguments[0];

                    var command = commandFactory.Create(commandName, new object[] { arguments });
                    string result = command.Execute();
                    outputWriter.Write(result);
                }
                catch (Exception ex)
                {
                    outputWriter.Write(ex.Message);
                }
            }
        }
    }
}
