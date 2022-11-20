namespace YachtClubManagement.ClubBoats;

public class ClubBoat : ClubBoatBase
{
    public string? ClassOfBoat { get; set; }
    
    public override string ToString() => $"Id łodzi: {Id}, typ jachtu: {ClassOfBoat}";

}