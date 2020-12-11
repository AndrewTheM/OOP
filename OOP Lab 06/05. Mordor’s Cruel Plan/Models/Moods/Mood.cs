namespace MordorsCruelPlan.Models.Moods
{
    public abstract class Mood
    {
        public string Name => GetType().Name;
    }
}
