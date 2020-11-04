using System.Collections.Generic;

namespace MilitaryElite.Models.Interfaces
{
    public interface IEngineer
    {
        List<IRepair> Repairs { get; }
    }
}
