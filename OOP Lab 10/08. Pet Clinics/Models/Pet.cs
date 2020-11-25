using PetClinics.Helpers;

namespace PetClinics.Models
{
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public string Name
        {
            get => name;
            set => name = PropertyCheck.StringNotEmpty(value, nameof(Name));
        }

        public int Age
        {
            get => age;
            set => age = PropertyCheck.NumberNotNegative(value, nameof(Age));
        }

        public string Kind
        {
            get => kind;
            set => kind = PropertyCheck.StringNotEmpty(value, nameof(Kind));
        }

        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }

        public override string ToString()
            => $"{Name} {Age} {Kind}";
    }
}
