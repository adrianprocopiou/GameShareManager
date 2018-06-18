using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Repositories
{
    public interface IFriendRepository : IRepository<Friend, FriendFilter>
    {
        
    }
}