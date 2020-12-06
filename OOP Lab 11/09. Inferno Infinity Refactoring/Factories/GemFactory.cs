using InfernoInfinity.Contracts;

namespace InfernoInfinity.Factories
{
    public class GemFactory : ReflectiveFactory<IGem>
    {
        public GemFactory()
            : base("InfernoInfinity.Models.Gems")
        {
        }
    }
}
