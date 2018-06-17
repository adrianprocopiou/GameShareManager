﻿using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class GameAppService : BaseAppService<Game,GameViewModel,GameShareManagerContext>, IGameAppService
    {
        public GameAppService(IUnitOfWork<GameShareManagerContext> uow, IGameService service) : base(uow, service)
        {
        }
    }
}