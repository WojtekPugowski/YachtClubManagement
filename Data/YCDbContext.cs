using Microsoft.EntityFrameworkCore;
using YachtClubManagement.ClubBoats;
using YachtClubManagement.Members;

namespace YachtClubManagement.Data;

public class YcDbContext : DbContext
{
    public DbSet<Member> Members => Set<Member>();
    public DbSet<ClubBoat> ClubBoats => Set<ClubBoat>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("YCAppDb");
    }
}