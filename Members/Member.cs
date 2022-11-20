namespace YachtClubManagement.Members;

public class Member : MemberBase
{
    public string? FirstName { get; set; }
    public string? SureName { get; set; }

    public override string ToString() => $"Id: {Id}, Nazwisko i imię: {SureName} {FirstName}";
}