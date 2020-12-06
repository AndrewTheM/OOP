namespace BarracksWars.Core.Factories
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNamespace = "BarracksWars.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            try
            {
                var unit = Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(t => t.Namespace == UnitNamespace
                                                && t.Name.ToLower() == unitType.ToLower())
                                   .SingleOrDefault();

                var instance = Activator.CreateInstance(unit);
                return (IUnit)instance;
            }
            catch
            {
                throw new ArgumentException("The provided unit type does not exist.");
            }
        }
    }
}
