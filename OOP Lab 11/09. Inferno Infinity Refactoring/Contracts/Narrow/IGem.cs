using InfernoInfinity.Contracts.Wide;
using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Contracts.Narrow
{
    public interface IGem : IStattable
    {
        GemClarity Clarity { get; }
    }
}
