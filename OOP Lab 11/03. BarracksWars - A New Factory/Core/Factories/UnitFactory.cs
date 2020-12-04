namespace BarracksWars.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string Namespace = "BarracksWars.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"{Namespace}.{unitType}");

            if (type == null)
                throw new ArgumentException("The provided entity does not exist.");

            var instance = Activator.CreateInstance(type);

            if (instance is not IUnit unit)
                throw new ArgumentException("The provided entity is not a Unit.");

            return unit;
        }
    }
}
