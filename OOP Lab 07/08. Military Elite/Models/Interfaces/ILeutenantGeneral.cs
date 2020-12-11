using System.Collections.Generic;

namespace MilitaryElite.Models.Interfaces
{
    public interface ILeutenantGeneral
    {
        List<IPrivate> Privates { get; }
    }
}
