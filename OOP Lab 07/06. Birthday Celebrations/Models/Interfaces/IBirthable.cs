namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IBirthable : IEntity
    {
        string Birthdate { get; set; }
    }
}
