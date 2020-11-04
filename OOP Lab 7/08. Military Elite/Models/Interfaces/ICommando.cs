using System.Collections.Generic;

namespace MilitaryElite.Models.Interfaces
{
    public interface ICommando
    {
        List<IMission> Missions { get; }
    }
}
