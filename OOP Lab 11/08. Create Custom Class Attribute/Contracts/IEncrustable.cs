using System.Collections.Generic;

namespace InfernoInfinity.Contracts
{
    public interface IEncrustable
    {
        ICollection<IGem> GemSockets { get; }

        void InsertGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
