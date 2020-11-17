using KingsGambitExtended.Models.Interfaces;
using System;

namespace KingsGambitExtended.Models.Base
{
    public abstract class Servant : Person, IKillable, IReactingToAttack
    {
        protected int hitsReceived;
        protected int hitsToKill;

        public bool IsAlive => (hitsReceived < hitsToKill);

        protected Servant(string name, int hitsToKill) : base(name)
        {
            this.hitsToKill = hitsToKill;
        }

        public event EventHandler Killed;

        public void TakeHit()
        {
            if (IsAlive)
                ++hitsReceived;

            if (!IsAlive)
                Die();
        }

        protected virtual void Die()
            => Killed?.Invoke(this, EventArgs.Empty);

        public abstract void React();
    }
}
