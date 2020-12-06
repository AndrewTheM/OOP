using InfernoInfinity.Contracts.Narrow;
using InfernoInfinity.Helpers;
using InfernoInfinity.Models.Enumerations;

namespace InfernoInfinity.Models.Gems
{
    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        public GemClarity Clarity { get; }

        public int Strength
        {
            get => strength + (int)Clarity;
            private set => strength = PropertyCheck.NumberNotNegative(value);
        }

        public int Agility
        {
            get => agility + (int)Clarity;
            private set => agility = PropertyCheck.NumberNotNegative(value);
        }

        public int Vitality
        {
            get => vitality + (int)Clarity;
            private set => vitality = PropertyCheck.NumberNotNegative(value);
        }

        protected Gem(GemClarity clarity, int strength, int agility, int vitality)
        {
            Clarity = clarity;
            Strength = strength;
            Agility = agility;
            Vitality = vitality;
        }
    }
}
