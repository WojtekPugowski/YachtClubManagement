namespace YachtClubManagement.Entities;

public class Member : EntityBase
{
    public string? FirstName { get; set; }
    public string? SureName { get; set; }

    public override string ToString() => $"Id: {Id}, Nazwisko i imię: {SureName} {FirstName}";
}