using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(GemClarity clarity)
            : base(clarity, 2, 8, 4)
        {
        }
    }
}
