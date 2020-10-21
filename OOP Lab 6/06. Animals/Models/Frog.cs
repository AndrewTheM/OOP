﻿using Animals.Models.Base;

namespace Animals.Models
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound() => "Ribbit";
    }
}
