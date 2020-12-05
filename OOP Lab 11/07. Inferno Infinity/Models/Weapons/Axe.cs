using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Models.Weapons
{
    public class Axe : Weapon
    {
        public Axe(WeaponRarity rarity, string name)
            : base(rarity, name, 5, 10, 4)
        {
        }
    }
}
