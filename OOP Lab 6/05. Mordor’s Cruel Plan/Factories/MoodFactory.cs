using MordorsCruelPlan.Models.Moods;

namespace MordorsCruelPlan.Factories
{
    public class MoodFactory
    {
        public Mood ProduceMood(int happinessPoints)
        {
            if (happinessPoints < -5)
                return new Angry();
            if (happinessPoints <= 0)
                return new Sad();
            if (happinessPoints <= 15)
                return new Happy();
            return new JavaScript();
        }
    }
}
