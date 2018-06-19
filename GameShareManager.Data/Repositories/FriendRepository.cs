using System.Linq;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Extension;

namespace GameShareManager.Data.Repositories
{
    public class FriendRepository : BaseRepository<Friend, FriendFilter>, IFriendRepository
    {
        public FriendRepository(IDbContext context) : base(context)
        {
        }

        public override DataTableResult<Friend> GetByFilter(FriendFilter filter)
        {
            var friends = DbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                friends = friends.Where(c => c.Name.Trim().ToLower().Contains(filter.Name.Trim().ToLower()) ||
                                             c.Nickname.Trim().ToLower().Contains(filter.Name.Trim().ToLower()));
            }


            friends = filter.order.Any(o => o.dir == "DESC") ? friends.OrderByDescending(x => x.Name) : friends.OrderBy(x => x.Name);


            return friends.ToDataTableResult(filter.draw, filter.start, filter.length);
        }
    }
}