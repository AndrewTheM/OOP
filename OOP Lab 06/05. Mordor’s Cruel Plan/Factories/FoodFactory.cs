using MordorsCruelPlan.Models.Food;

namespace MordorsCruelPlan.Factories
{
    public class FoodFactory
    {
        public Food ProduceFood(string name)
        {
            return name switch
            {
                nameof(Cram) => new Cram(),
                nameof(Lembas) => new Lembas(),
                nameof(Apple) => new Apple(),
                nameof(Melon) => new Melon(),
                nameof(HoneyCake) => new HoneyCake(),
                nameof(Mushrooms) => new Mushrooms(),
                _ => new UnknownFood()
            };
        }
    }
}
