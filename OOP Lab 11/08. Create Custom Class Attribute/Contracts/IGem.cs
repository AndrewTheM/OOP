using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Contracts
{
    public interface IGem : IStattable
    {
        GemClarity Clarity { get; }
    }
}
