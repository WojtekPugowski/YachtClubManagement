using YachtClubManagement.ClubBoats;

namespace YachtClubManagement.Repositories;

public class ClubBoatRepository
{
    private List<ClubBoatBase> _clubBoats = new();

    public void Add(ClubBoat clubBoat)
    {
        clubBoat.Id = _clubBoats.Count + 1;
        _clubBoats.Add(clubBoat);
    }
    public void Save()
    {
        foreach (var clubBoat in _clubBoats) 
        {
            Console.WriteLine(clubBoat);
        }
    }

    public ClubBoat GetById(int id)
    {
        return (ClubBoat)_clubBoats.Single(item => item.Id == id);    //??? czemu muszę castować??? 
    }
}