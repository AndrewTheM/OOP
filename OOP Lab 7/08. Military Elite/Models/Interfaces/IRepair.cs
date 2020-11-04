namespace MilitaryElite.Models.Interfaces
{
    public interface IRepair
    {
        string PartName { get; set; }

        int HoursWorked { get; set; }
    }
}
