namespace GameShareManager.Data.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void SaveChanges();
    }
}