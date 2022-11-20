using YachtClubManagement.ClubBoats;
using YachtClubManagement.Data;
using YachtClubManagement.Members;
using YachtClubManagement.Repositories;

var memberRepository = new SqlRepository<Member>(new YcDbContext());
var boatRepository = new SqlRepository<ClubBoat>(new YcDbContext());
AddMembers(memberRepository);
AddContender(memberRepository);
AddInstruktor(memberRepository);
AddClubBoat(boatRepository);
WriteAllToConsole(memberRepository);
Console.WriteLine("---- łodzie klubowe ----");
WriteAllToConsole(boatRepository);


static void AddMembers(IRepository<Member> memberRepository)
{
    memberRepository.Add(new Member { FirstName = "Ania", SureName = "Memebrowska" });
    memberRepository.Add(new Member { FirstName = "Tomek", SureName = "Memebrowski" });
    memberRepository.Save();
}

static void AddContender(IRepository<Member> contenderRepository)
{
    contenderRepository.Add(new Competitor { FirstName = "Ola", SureName = "Zawodnikowski" });
    contenderRepository.Add(new Competitor { FirstName = "Tomek", SureName = "Zawodnikowska" });
    contenderRepository.Save();
}

static void AddInstruktor(IRepository<Member> instructorRepository)
{
    instructorRepository.Add(new Instructor { FirstName = "Jan", SureName = "Instrukorski" });
    instructorRepository.Add(new Instructor { FirstName = "Maria", SureName = "Instrukorska" });
    instructorRepository.Save();
}

void AddClubBoat(IRepository<ClubBoat> boatRepository)
{
    boatRepository.Add(new ClubBoat {ClassOfBoat = "Optimist POL1222"});
    boatRepository.Add(new ClubBoat {ClassOfBoat = "Optimist POL1329"});
    boatRepository.Add(new ClubBoat {ClassOfBoat = "Cadet POL964"});
    boatRepository.Save();


}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}