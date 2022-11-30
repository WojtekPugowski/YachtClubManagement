using YachtClubManagement.ClubBoats;
using YachtClubManagement.Data;
using YachtClubManagement.Members;
using YachtClubManagement.Repositories;
using YachtClubManagement.Repositories.Extensions;

var memberRepository = new SqlRepository<Member>(new YcDbContext(), MemberAdded);
var boatRepository = new SqlRepository<ClubBoat>(new YcDbContext(), ClubBoatAdded);

AddMembers(memberRepository);
WriteAllToConsole(memberRepository);
Console.WriteLine("\n---- łodzie klubowe ----");
AddClubBoat(boatRepository);
WriteAllToConsole(boatRepository);

static void MemberAdded(Member item)
{
    Console.WriteLine($"{item.SureName}, {item.FirstName} added");
}
static void ClubBoatAdded(ClubBoat item)
{
    Console.WriteLine($"{item.ClassOfBoat}, added");
}

static void AddMembers(IRepository<Member> memberRepository)
{
    var members = new List<Member>
    {
        new Member { FirstName = "Ania", SureName = "Membrowska" },
        new Member { FirstName = "Tomek", SureName = "Membrowski" },

        new Competitor { FirstName = "Ola", SureName = "Zawodnikowski" },
        new Competitor { FirstName = "Tomek", SureName = "Zawodnikowska" },

        new Instructor { FirstName = "Jan", SureName = "Instrukorski" },
        new Instructor { FirstName = "Maria", SureName = "Instrukorska" }
    };
    memberRepository.AddBatch(members);
}

static void AddClubBoat(IRepository<ClubBoat> clubBoatRespository)
{
    var clubBoats = new List<ClubBoat>
    {
        new ClubBoat { ClassOfBoat = "Optimist POL1222" },
        new ClubBoat { ClassOfBoat = "Optimist POL1329" },
        new ClubBoat { ClassOfBoat = "Cadet POL964" }
    };
    clubBoatRespository.AddBatch(clubBoats);
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}