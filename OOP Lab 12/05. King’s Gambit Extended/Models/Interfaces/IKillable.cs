using System;

namespace KingsGambitExtended.Models.Interfaces
{
    public interface IKillable
    {
        event EventHandler Killed;

        void TakeHit();
    }
}
