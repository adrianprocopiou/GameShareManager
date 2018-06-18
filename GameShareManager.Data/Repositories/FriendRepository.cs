using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public class FriendRepository : BaseRepository<Friend, FriendFilter>, IFriendRepository
    {
        public FriendRepository(IDbContext context) : base(context)
        {
        }

        public override DataTableResult<Friend> GetByFilter(FriendFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}