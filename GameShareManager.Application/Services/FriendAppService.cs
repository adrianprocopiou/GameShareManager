using GameShareManager.Application.Filters;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class FriendAppService : BaseAppService<Friend,FriendViewModel,FriendFilter,FriendAppFilter,GameShareManagerContext>, IFriendAppService
    {
        public FriendAppService(IUnitOfWork<GameShareManagerContext> uow, IFriendService service) : base(uow, service)
        {
        }
    }
}