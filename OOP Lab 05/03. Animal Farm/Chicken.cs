using System;

namespace AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentException("Age should be between 0 and 15.");
                age = value;
            }
        }

        public int ProductPerDay => CalculateProductPerDay();

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private int CalculateProductPerDay()
            => (Age >= 10) ? Age - 9 : 0;
    }
}
