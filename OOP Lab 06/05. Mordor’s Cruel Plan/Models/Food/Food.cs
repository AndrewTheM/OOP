namespace MordorsCruelPlan.Models.Food
{
    public abstract class Food
    {
        public int HappinessPoints { get; }

        protected Food(int happinessPoints)
        {
            HappinessPoints = happinessPoints;
        }
    }
}
