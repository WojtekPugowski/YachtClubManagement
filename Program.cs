using YachtClubManagement.Data;
using YachtClubManagement.Entities;
using YachtClubManagement.Repositories;

var memberRepository = new SqlRepository<Member>(new YcmDbContext());
AddMembers(memberRepository);
AddContender(memberRepository);
AddInstruktor(memberRepository);
WriteAllToConsole(memberRepository);



static void AddMembers(IRepository<Member> memberRepository)
{
    memberRepository.Add(new Member { FirstName = "Ania", SureName = "Memebrowska" });
    memberRepository.Add(new Member { FirstName = "Tomek", SureName = "Memebrowski" });
    memberRepository.Save();
}

static void AddContender(IRepository<Member> contenderRepository)
{
    contenderRepository.Add(new Contender { FirstName = "Ola", SureName = "Zawodnikowski" });
    contenderRepository.Add(new Contender { FirstName = "Tomek", SureName = "Zawodnikowska" });
    contenderRepository.Save();
}

static void AddInstruktor(IRepository<Member> instructorRepository)
{
    instructorRepository.Add(new Instructor { FirstName = "Jan", SureName = "Instrukorski" });
    instructorRepository.Add(new Instructor { FirstName = "Maria", SureName = "Instrukorska" });
    instructorRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}