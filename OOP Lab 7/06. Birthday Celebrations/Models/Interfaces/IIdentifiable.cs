namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IIdentifiable : IEntity
    {
        string Id { get; set; }
    }
}
