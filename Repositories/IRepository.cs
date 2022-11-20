using YachtClubManagement.ClubBoats;
using YachtClubManagement.Members;

namespace YachtClubManagement.Repositories;

public interface IRepository<T>:IReadRepository<T>, IWriteRepository<T>
where T: class, IEntity
{
    
}