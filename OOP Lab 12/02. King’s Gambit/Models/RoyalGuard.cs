using KingsGambit.Models.Base;
using System;

namespace KingsGambit.Models
{
    public class RoyalGuard : Servant
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void React()
        {
            if (Alive)
                Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
