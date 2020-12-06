using InfernoInfinity.Contracts;
using InfernoInfinity.Models.Enumerations;
using System;

namespace InfernoInfinity.Commands
{
    public class CreateCommand : Command
    {
        private IWeaponRepository repository;

        private IReflectiveFactory<IWeapon> weaponFactory;

        public CreateCommand(string[] arguments) : base(arguments)
        {
        }

        public override string Execute()
        {
            string fullWeaponType = Arguments[1],
                   weaponName = Arguments[2];

            string[] splitWeaponType = fullWeaponType.Split(' ');
            string weaponRarityName = splitWeaponType[0],
                   weaponType = splitWeaponType[1];

            var rarity = Enum.Parse<WeaponRarity>(weaponRarityName);
            var weapon = weaponFactory.Create(weaponType, rarity, weaponName);

            repository.Add(weapon);
            return string.Empty;
        }
    }
}
