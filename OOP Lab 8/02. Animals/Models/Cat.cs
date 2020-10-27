﻿using System;

namespace Animals.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
            => base.ExplainSelf() + Environment.NewLine + "MEEOW";
    }
}
