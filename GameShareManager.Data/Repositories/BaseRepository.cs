using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TFilter> : IRepository<TEntity,TFilter> where TEntity:Entity where TFilter:BaseFilter
    {
        protected readonly IDbSet<TEntity> DbSet;
        protected readonly IDbContext DbContext;

        protected BaseRepository(IDbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            obj.Id = Guid.NewGuid();
           return DbSet.Add(obj);
        }

        public TEntity FindById(Guid id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public TEntity Update(TEntity obj)
        {
            var entry = DbContext.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return entry.Entity;
        }

        public void Remove(TEntity obj)
        {
            var entry = DbContext.Entry(obj);
            if (entry.State == EntityState.Detached)
            {
                var localObject = DbSet.Local.FirstOrDefault(x => x.Id == obj.Id);
                if (localObject != default(TEntity))
                {
                    DbSet.Remove(localObject);
                }
                else
                {
                    DbSet.Attach(obj);
                    DbSet.Remove(obj);
                }
            }
            else
            {
                DbSet.Remove(obj);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public abstract DataTableResult<TEntity> GetByFilter(TFilter filter);

        public void Dispose()
        {
            DbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}