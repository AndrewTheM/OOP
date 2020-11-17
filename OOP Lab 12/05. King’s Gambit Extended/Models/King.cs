using KingsGambitExtended.Models.Base;
using KingsGambitExtended.Models.Interfaces;
using System;

namespace KingsGambitExtended.Models
{
    public class King : Person, IAttackable
    {
        public King(string name) : base(name)
        {
        }

        public event IAttackable.AttackedEventHandler Attacked;

        public void OnAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            Attacked?.Invoke();
        }

        public void ForgetServant(object sender, EventArgs e)
        {
            if (sender is Servant servant)
                Attacked -= servant.React;
        }
    }
}
