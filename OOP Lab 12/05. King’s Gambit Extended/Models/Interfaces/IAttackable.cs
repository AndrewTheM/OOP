﻿namespace KingsGambitExtended.Models.Interfaces
{
    public interface IAttackable
    {
        delegate void AttackedEventHandler();
        event AttackedEventHandler Attacked;

        void OnAttack();
    }
}
