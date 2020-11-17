using KingsGambit.Models.Base;
using KingsGambit.Models.Interfaces;
using System;

namespace KingsGambit.Models
{
    public class Footman : Servant
    {
        public Footman(string name) : base(name)
        {
        }

        public override void React()
        {
            if (Alive)
                Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
