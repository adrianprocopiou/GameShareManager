using System.Data.Entity;
using System.Linq;
using System.Web;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using Microsoft.AspNet.Identity;
using NLog;
using Z.EntityFramework.Plus;

namespace GameShareManager.Data.Context
{
    public abstract class BaseDbContext: DbContext, IDbContext
    {
        private static Logger _logger = LogManager.GetLogger("LoggerBD");
        protected string UserId = HttpContext.Current.User.Identity.GetUserId();

        protected BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.Log = x => _logger.Info(x);
            this.Filter<Entity>(q => q.Where(x => x.OwnerUserId == UserId));
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}