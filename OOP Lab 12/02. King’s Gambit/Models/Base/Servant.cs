using KingsGambit.Models.Interfaces;
using System;

namespace KingsGambit.Models.Base
{
    public abstract class Servant : Person, IKillable, IReactingToAttack
    {
        public bool Alive { get; private set; }

        protected Servant(string name) : base(name)
        {
            Alive = true;
        }

        public void Die()
        {
            if (!Alive)
                throw new InvalidOperationException($"{GetType().Name} {Name} is already dead.");
            Alive = false;
        }

        public abstract void React();
    }
}
