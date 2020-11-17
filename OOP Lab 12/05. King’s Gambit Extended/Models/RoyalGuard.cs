using KingsGambitExtended.Models.Base;
using System;

namespace KingsGambitExtended.Models
{
    public class RoyalGuard : Servant
    {
        public RoyalGuard(string name) : base(name, 3)
        {
        }

        public override void React()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
