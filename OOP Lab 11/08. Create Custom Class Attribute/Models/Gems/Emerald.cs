using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(GemClarity clarity)
            : base(clarity, 1, 4, 9)
        {
        }
    }
}
