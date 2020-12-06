using InfernoInfinity.Contracts.Narrow;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfernoInfinity.Repositories
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly ICollection<IWeapon> weapons;

        public ICollection<IWeapon> Weapons
            => (weapons as List<IWeapon>).AsReadOnly();

        public WeaponRepository()
        {
            weapons = new List<IWeapon>();
        }

        public void Add(IWeapon item)
        {
            try
            {
                var weapon = Get(item.Name);
                throw new InvalidOperationException("A weapon with such name already exists.");
            }
            catch (ArgumentException)
            {
                weapons.Add(item);
            }
        }

        public void Remove(string name)
        {
            var weapon = Get(name);
            weapons.Remove(weapon);
        }

        public IWeapon Get(string name)
        {
            return weapons.SingleOrDefault(w => w.Name == name)
               ?? throw new ArgumentException("There is no weapon with such name.", nameof(name));
        }
    }
}
