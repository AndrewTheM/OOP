namespace KingsGambit.Models.Interfaces
{
    public interface IKillable
    {
        bool Alive { get; }

        void Die();
    }
}
