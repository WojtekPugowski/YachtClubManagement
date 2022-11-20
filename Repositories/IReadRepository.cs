using YachtClubManagement.ClubBoats;
using YachtClubManagement.Members;

namespace YachtClubManagement.Repositories;

public interface IReadRepository<out T> where T: class, IEntity
{
 IEnumerable<T> GetAll();
 T GetById(int id);
}