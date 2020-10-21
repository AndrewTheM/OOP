using System;
using System.Text;

namespace Animals.Models.Base
{
    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get => name;
            protected set => name = ValidateString(value);
        }

        public int Age
        {
            get => age;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid input!");
                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            protected set => gender = ValidateString(value);
        }

        public string AnimalType => GetType().Name;

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        private string ValidateString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalid input!");
            return value;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine(AnimalType)
                .AppendLine($"{Name} {Age} {Gender}")
                .AppendLine(ProduceSound());

            return strBuilder.ToString();
        }
    }
}
