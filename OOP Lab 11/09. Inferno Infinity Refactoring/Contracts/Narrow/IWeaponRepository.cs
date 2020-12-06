using InfernoInfinity.Contracts.Generic;
using System.Collections.Generic;

namespace InfernoInfinity.Contracts.Narrow
{
    public interface IWeaponRepository : IRepository<IWeapon>
    {
        ICollection<IWeapon> Weapons { get; }
    }
}
