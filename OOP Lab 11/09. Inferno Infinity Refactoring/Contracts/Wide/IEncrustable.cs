using InfernoInfinity.Contracts.Narrow;
using System.Collections.Generic;

namespace InfernoInfinity.Contracts.Wide
{
    public interface IEncrustable
    {
        ICollection<IGem> GemSockets { get; }

        void InsertGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
