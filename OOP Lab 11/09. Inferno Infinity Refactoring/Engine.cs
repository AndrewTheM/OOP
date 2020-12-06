using InfernoInfinity.Contracts.Generic;
using InfernoInfinity.Contracts.Narrow;
using System;

namespace InfernoInfinity
{
    public class Engine : IEngine
    {
        private IReflectiveFactory<ICommand> commandFactory;

        public void Run()
        {
            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var arguments = line.Split(';');
                    string commandName = arguments[0];
                    var command = commandFactory.Create(commandName, new object[] { arguments });
                    string result = command.Execute();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
