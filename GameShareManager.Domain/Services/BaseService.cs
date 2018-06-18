﻿using System;
using System.Collections.Generic;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public abstract class BaseService<TEntity, TFilter> : IService<TEntity, TFilter> where TEntity : Entity where TFilter : BaseFilter
    {
        protected readonly IRepository<TEntity, TFilter> Repository;

        protected BaseService(IRepository<TEntity, TFilter> repository)
        {
            Repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            return Repository.Add(obj);
        }

        public TEntity FindById(Guid id)
        {
            return Repository.FindById(id);
        }

        public void Remove(TEntity obj)
        {
            Repository.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public abstract DataTableResult<TEntity> GetDataTableResultByFilter(TFilter filter);


        public TEntity Update(TEntity obj)
        {
            return Repository.Update(obj);
        }
    }
}