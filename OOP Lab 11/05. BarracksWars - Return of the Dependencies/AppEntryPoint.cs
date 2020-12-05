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
            Injector.Instance.AddSingleton<IRepository, UnitRepository>();
            Injector.Instance.AddTransient<IUnitFactory, UnitFactory>();
            Injector.Instance.AddTransient<ICommandInterpreter, CommandInterpreter>();
        }
    }
}
