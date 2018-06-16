using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class GameService : BaseService<Game>, IGameService
    {
        public GameService(IGameRepository repository) : base(repository)
        {
        }
    }
}