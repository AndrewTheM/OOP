using KingsGambitExtended.Models.Base;
using System;

namespace KingsGambitExtended.Models
{
    public class Footman : Servant
    {
        public Footman(string name) : base(name, 2)
        {
        }

        public override void React()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
