using GameShareManager.Application.Interfaces;
using GameShareManager.Application.Services;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Data.Repositories;
using GameShareManager.Data.UnitOfWork;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;
using GameShareManager.Domain.Services;
using LightInject;

namespace GameShareManager.IoC
{
    public static class LightInjectConfig
    {
        private static ServiceContainer _serviceContainer;

        public static ServiceContainer ServiceContainer => _serviceContainer ?? (_serviceContainer = GetContainer());


        private static ServiceContainer GetContainer()
        {
            var container = new ServiceContainer();

            container.Register<IDbContext, GameShareManagerContext>(new PerScopeLifetime());

            container.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>), new PerScopeLifetime());
            container.Register(typeof(UnitOfWorkService<>), typeof(UnitOfWorkService<>), new PerScopeLifetime());


            container.Register(typeof(IService<>), typeof(BaseService<>), new PerScopeLifetime());


            // Company
            container.Register<ICompanyAppService, CompanyAppService>(new PerScopeLifetime());
            container.Register<ICompanyService, CompanyService>(new PerScopeLifetime());
            container.Register<ICompanyRepository, CompanyRepository>(new PerScopeLifetime());

            // Friend
            container.Register<IFriendAppService, FriendAppService>(new PerScopeLifetime());
            container.Register<IFriendService, FriendService>(new PerScopeLifetime());
            container.Register<IFriendRepository, FriendRepository>(new PerScopeLifetime());

            // Game
            container.Register<IGameAppService, GameAppService>(new PerScopeLifetime());
            container.Register<IGameService, GameService>(new PerScopeLifetime());
            container.Register<IGameRepository, GameRepository>(new PerScopeLifetime());

            return container;
        }
    }
}