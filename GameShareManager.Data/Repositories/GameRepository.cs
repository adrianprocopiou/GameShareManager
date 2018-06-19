using System;
using System.Data.Entity;
using System.Linq;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Extension;

namespace GameShareManager.Data.Repositories
{
    public class GameRepository : BaseRepository<Game, GameFilter>, IGameRepository
    {
        public GameRepository(IDbContext context) : base(context)
        {
        }

        public new Game FindById(Guid id)
        {
            return DbSet.Include(x=>x.Company).Include(x=>x.Friend).FirstOrDefault(x => x.Id == id);
        }

        public override DataTableResult<Game> GetByFilter(GameFilter filter)
        {
            var games = DbSet.Include(x=>x.Company).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                games = games.Where(c => c.Name.Trim().ToLower().Contains(filter.Name.Trim().ToLower()));
            }

            if (filter.CompanyId != Guid.Empty)
            {
                games = games.Where(x => x.CompanyId == filter.CompanyId);
            }

            if (filter.OnlyAvailable)
            {
                games = games.Where(x => !x.FriendId.HasValue);
            }
            else if (filter.FrienId != Guid.Empty)
            {
                games = games.Where(x => x.FriendId == filter.FrienId);
            }


            games = filter.order.Any(o => o.dir == "DESC") ? games.OrderByDescending(x => x.Name) : games.OrderBy(x => x.Name);


            return games.ToDataTableResult(filter.draw, filter.start, filter.length);
        }

        public override Select2Result<Game> GetSelect2Filter(int page, string term)
        {
            var games = DbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(term))
                games = games.Where(x => x.Name.Trim().ToLower().Contains(term.Trim().ToLower()));

            games = games.OrderBy(x => x.Name);

            return games.ToSelect2Result(page);
        }
    }
}