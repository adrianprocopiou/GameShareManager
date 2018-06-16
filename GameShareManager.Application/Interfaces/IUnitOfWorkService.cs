using GameShareManager.Data.Interfaces;

namespace GameShareManager.Application.Interfaces
{
    public interface IBaseAppService<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}