namespace CatLady.Models
{
    public abstract class Cat
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}
