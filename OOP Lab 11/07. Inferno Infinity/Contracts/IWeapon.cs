using InfernoInfinity.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity.Contracts
{
    public interface IWeapon : IEncrustable, IDamaging, INameable, IStattable
    {
        WeaponRarity Rarity { get; }
    }
}
