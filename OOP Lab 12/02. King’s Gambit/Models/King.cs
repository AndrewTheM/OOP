using KingsGambit.Models.Base;
using KingsGambit.Models.Interfaces;
using System;

namespace KingsGambit.Models
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
    }
}
