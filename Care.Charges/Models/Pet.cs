namespace Care.Charges.Models;

public record Pet
{
    public string Name { get; set; }
    public DateOnly CheckInDate { get; set; }
    public int NumberOfHours { get; set; }
}
