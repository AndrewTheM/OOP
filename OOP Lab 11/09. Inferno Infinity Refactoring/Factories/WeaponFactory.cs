using InfernoInfinity.Contracts.Narrow;

namespace InfernoInfinity.Factories
{
    public class WeaponFactory : ReflectiveFactory<IWeapon>
    {
        public WeaponFactory()
            : base("InfernoInfinity.Models.Weapons")
        {
        }
    }
}
