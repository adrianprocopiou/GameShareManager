using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class GameService : BaseService<Game, GameFilter>, IGameService
    {
        public GameService(IGameRepository repository) : base(repository)
        {
        }
    }
}