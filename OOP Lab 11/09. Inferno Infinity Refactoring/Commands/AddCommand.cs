using InfernoInfinity.Contracts.Generic;
using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Helpers;
using InfernoInfinity.Models.Enumerations;
using System;

namespace InfernoInfinity.Commands
{
    public class AddCommand : Command
    {
        private IWeaponRepository repository;

        private IReflectiveFactory<IGem> gemFactory;

        public AddCommand(string[] arguments) : base(arguments)
        {
            Injector.Instance.PerformInjection(this);
        }

        public override string Execute()
        {
            string weaponName = Arguments[1];
            var weapon = repository.Get(weaponName);

            int socketIndex = int.Parse(Arguments[2]);
            string gemFullType = Arguments[3];

            var gemSplitType = gemFullType.Split(' ');
            string gemClarityName = gemSplitType[0],
                   gemType = gemSplitType[1];

            var gemClarity = Enum.Parse<GemClarity>(gemClarityName);
            var gem = gemFactory.Create(gemType, gemClarity);

            weapon.InsertGem(gem, socketIndex);
            return base.Execute();
        }
    }
}
