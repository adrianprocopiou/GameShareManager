using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public class GameRepository : BaseRepository<Game, GameFilter>, IGameRepository
    {
        public GameRepository(IDbContext context) : base(context)
        {
        }

        public override DataTableResult<Game> GetByFilter(GameFilter filter)
        {
            throw new System.NotImplementedException();
        }
    }
}