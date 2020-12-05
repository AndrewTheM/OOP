using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(GemClarity clarity)
            : base(clarity, 7, 2, 5)
        {
        }
    }
}
