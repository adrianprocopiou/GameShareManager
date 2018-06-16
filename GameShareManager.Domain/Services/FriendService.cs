using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class FriendService : BaseService<Friend>, IFriendService
    {
        public FriendService(IFriendRepository repository) : base(repository)
        {
        }
    }
}