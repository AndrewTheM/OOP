using InfernoInfinity.Contracts;

namespace InfernoInfinity.Factories
{
    public class WeaponFactory : ReflectiveFactory<IWeapon>
    {
        public WeaponFactory()
            : base("InfernoInfinity.Models.WeaponsW")
        {
        }
    }
}
