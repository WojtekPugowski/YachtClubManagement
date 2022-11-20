using YachtClubManagement.Entities;

namespace YachtClubManagement.Repositories;

public interface IRepository<T>:IReadRepository<T>, IWriteRepository<T>
where T: class, IEntity
{
    
}