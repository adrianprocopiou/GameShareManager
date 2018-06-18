using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class FriendService : BaseService<Friend,FriendFilter>, IFriendService
    {
        public FriendService(IFriendRepository repository) : base(repository)
        {
        }


        public override DataTableResult<Friend> GetDataTableResultByFilter(FriendFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}