﻿using System;
using GameShareManager.Data.Interfaces;

namespace GameShareManager.Data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : IDbContext
    {
        private readonly IDbContext _dbContext;

        private bool _disposed;

        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}