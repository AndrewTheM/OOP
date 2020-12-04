﻿using BarracksWars.Contracts;

namespace BarracksWars.Core.Commands
{
    public class AddUnitCommand : Command
    {
        public AddUnitCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            var unit = UnitFactory.CreateUnit(unitType);

            Repository.AddUnit(unit);
            return $"{unitType} added!";
        }
    }
}
