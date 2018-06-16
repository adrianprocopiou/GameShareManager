using GameShareManager.Application.Interfaces;
using GameShareManager.Data.Interfaces;

namespace GameShareManager.Application.Services
{
    public class UnitOfWorkService<TContext> : IBaseAppService<TContext> where TContext : IDbContext
    {
        private readonly IUnitOfWork<TContext> _uow;

        public UnitOfWorkService(IUnitOfWork<TContext> uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }
    }
}