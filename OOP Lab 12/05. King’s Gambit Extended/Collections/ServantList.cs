using KingsGambitExtended.Models.Base;
using System;
using System.Collections.Generic;

namespace KingsGambitExtended.Collections
{
    public class ServantList : List<Servant>
    {
        public new void Add(Servant item)
        {
            item.Killed += RemoveKilledServant;
            base.Add(item);
        }

        private void RemoveKilledServant(object sender, EventArgs e)
        {
            if (sender is Servant servant)
            {
                servant.Killed -= RemoveKilledServant;
                Remove(servant);
            }
        }
    }
}
