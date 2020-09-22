namespace CatLady.Models
{
    public class Cymric : Cat
    {
        public double FurLength { get; set; }

        public Cymric(string name, double furLength) : base(name)
        {
            FurLength = furLength;
        }

        public override string ToString()
            => $"{nameof(Cymric)} {base.ToString()} {FurLength:0.00}";
    }
}
