using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public class FriendRepository : BaseRepository<Friend>, IFriendRepository
    {
        public FriendRepository(IDbContext context) : base(context)
        {
        }
    }
}