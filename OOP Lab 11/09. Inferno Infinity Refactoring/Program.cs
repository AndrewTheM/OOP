using InfernoInfinity.Contracts.Generic;
using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Contracts.Wide;
using InfernoInfinity.Factories;
using InfernoInfinity.Helpers;
using InfernoInfinity.IO;
using InfernoInfinity.Repositories;

namespace InfernoInfinity
{
    class Program
    {
        static void Main()
        {
            ConfigureInjection();
            var engine = new Engine();
            engine.Run();
        }

        private static void ConfigureInjection()
        {
            var injector = Injector.Instance;
            injector.AddSingleton<IWeaponRepository, WeaponRepository>();
            injector.AddTransient<IReflectiveFactory<ICommand>, CommandFactory>();
            injector.AddTransient<IReflectiveFactory<IWeapon>, WeaponFactory>();
            injector.AddTransient<IReflectiveFactory<IGem>, GemFactory>();
            injector.AddTransient<IReader, ConsoleInputReader>();
            injector.AddTransient<IWriter, ConsoleOutputWriter>();
        }
    }
}
