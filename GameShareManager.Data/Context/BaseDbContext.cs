using System.Data.Entity;
using GameShareManager.Data.Interfaces;
using NLog;

namespace GameShareManager.Data.Context
{
    public abstract class BaseDbContext: DbContext, IDbContext
    {
        private static Logger _logger = LogManager.GetLogger("LoggerBD");

        protected BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.Log = x => _logger.Info(x);
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}