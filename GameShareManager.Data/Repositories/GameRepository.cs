using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(IDbContext context) : base(context)
        {
        }
    }
}