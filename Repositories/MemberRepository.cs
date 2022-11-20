using YachtClubManagement.Entities;

namespace YachtClubManagement.Repositories;

public class MemberRepository
{
    private readonly List<Member> _members = new();

    public void Add(Member member)
    {
        member.Id = _members.Count + 1;
        _members.Add(member);
    }

    public void Save()
    {
        foreach (var member in _members)
        {
            Console.WriteLine(member);
        }
    }

    public Member GetById(int id)
    {
        return _members.Single(item => item.Id == id);
    }
}