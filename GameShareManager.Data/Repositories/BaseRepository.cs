using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;

namespace GameShareManager.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T:Entity
    {
        protected readonly IDbSet<T> DbSet;
        protected readonly IDbContext DbContext;
        public BaseRepository(IDbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<T>();
        }

        public T Add(T obj)
        {
           return DbSet.Add(obj);
        }

        public T FindById(Guid id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public T Update(T obj)
        {
            var entry = DbContext.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return entry.Entity;
        }

        public void Remove(T obj)
        {
            DbSet.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public void Dispose()
        {
            DbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}