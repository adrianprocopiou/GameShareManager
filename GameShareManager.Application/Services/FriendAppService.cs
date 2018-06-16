﻿using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class FriendAppService : BaseAppService<Friend,FriendViewModel,GameShareManagerContext>, IFriendAppService
    {
        public FriendAppService(IUnitOfWork<GameShareManagerContext> uow, IService<Friend> service) : base(uow, service)
        {
        }
    }
}