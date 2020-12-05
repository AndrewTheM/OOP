namespace BarracksWars.Core
{
    using System;
    using BarracksWars.Core.Attributes;
    using BarracksWars.Core.Helpers;
    using Contracts;

    class Engine : IRunnable
    {
        [Inject]
        private ICommandInterpreter interpreter;

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
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];

                    if (string.IsNullOrWhiteSpace(commandName))
                        continue;
                    
                    var command = interpreter.InterpretCommand(data, commandName);
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
