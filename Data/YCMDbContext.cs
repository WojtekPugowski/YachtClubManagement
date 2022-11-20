using Microsoft.EntityFrameworkCore;
using YachtClubManagement.Entities;

namespace YachtClubManagement.Data;

public class YcmDbContext : DbContext
{
    public DbSet<Member> Members => Set<Member>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("YcmAppDb");
    }
}

