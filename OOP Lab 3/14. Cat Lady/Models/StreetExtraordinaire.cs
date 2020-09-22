namespace CatLady.Models
{
    public class StreetExtraordinaire : Cat
    {
        public int Decibels { get; set; }

        public StreetExtraordinaire(string name, int decibels) : base(name)
        {
            Decibels = decibels;
        }

        public override string ToString()
            => $"{nameof(StreetExtraordinaire)} {base.ToString()} {Decibels}";
    }
}
