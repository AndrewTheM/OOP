using InfernoInfinity.Contracts.Wide;
using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Contracts.Narrow
{
    public interface IWeapon : IEncrustable, IDamaging, INameable, IStattable
    {
        WeaponRarity Rarity { get; }
    }
}
