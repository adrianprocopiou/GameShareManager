using System;
using System.Collections.Generic;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class BaseService<T> : IService<T> where T : Entity
    {
        protected readonly IRepository<T> Repository;

        public BaseService(IRepository<T> repository)
        {
            Repository = repository;
        }

        public T Add(T obj)
        {
            return Repository.Add(obj);
        }

        public T FindById(Guid id)
        {
            return Repository.FindById(id);
        }

        public void Remove(T obj)
        {
            Repository.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return Repository.GetAll();
        }

        public T Update(T obj)
        {
            return Repository.Update(obj);
        }
    }
}