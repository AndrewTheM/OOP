namespace BarracksWars
{
    using BarracksWars.Core.Helpers;
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            ConfigureInjection();
            var engine = new Engine();
            engine.Run();
        }

        static void ConfigureInjection()
        {
            var injector = Injector.Instance;
            injector.AddSingleton<IRepository, UnitRepository>();
            injector.AddTransient<IUnitFactory, UnitFactory>();
            injector.AddTransient<ICommandInterpreter, CommandInterpreter>();
        }
    }
}
