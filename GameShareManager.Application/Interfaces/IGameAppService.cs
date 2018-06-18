using GameShareManager.Application.Filters;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Application.Interfaces
{
    public interface IGameAppService: IAppService<GameViewModel, GameAppFilter>
    {
        
    }
}