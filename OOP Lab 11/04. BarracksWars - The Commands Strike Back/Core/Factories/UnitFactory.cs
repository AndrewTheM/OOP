namespace BarracksWars.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNamespace = "BarracksWars.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            var unit = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .Where(t => t.Namespace == UnitNamespace
                                            && t.Name.ToLower() == unitType.ToLower())
                               .SingleOrDefault();

            if (unit == null)
                throw new ArgumentException("The provided entity does not exist.");

            var instance = Activator.CreateInstance(unit);

            if (instance is not IUnit)
                throw new ArgumentException("The provided entity is not a Unit.");

            return (IUnit)instance;
        }
    }
}
