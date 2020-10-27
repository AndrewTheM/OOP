namespace Animals.Models
{
    public abstract class Animal
    {
        public string Name { get; protected set; }

        public string FavoriteFood { get; protected set; }

        protected Animal(string name, string favoriteFood)
        {
            Name = name;
            FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
            => $"I am {Name} and my favorite food is {FavoriteFood}";
    }
}
