namespace MilitaryElite.Models.Interfaces
{
    public interface IMission
    {
        string CodeName { get; set; }

        string State { get; }

        void Complete();
    }
}
