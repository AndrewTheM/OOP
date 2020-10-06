namespace JediGalaxy.Models
{
    public class Star
    {
        public int Value { get; set; }

        public bool IsDestroyed { get; set; }

        public Star(int value) => Value = value;
    }
}
