using System;
using System.Collections.Generic;
using AutoMapper;
using GameShareManager.Application.Interfaces;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class BaseAppService<TEntity, TViewModel, TContext> : UnitOfWorkService<TContext>, IAppService<TViewModel>
        where TContext : IDbContext
        where TEntity : Entity
        where TViewModel : class
    {
        protected readonly IService<TEntity> Service;

        public BaseAppService(IUnitOfWork<TContext> uow, IService<TEntity> service) : base(uow)
        {
            Service = service;
        }


        public TViewModel Add(TViewModel viewModel)
        {
            var entity = Mapper.Map<TEntity>(viewModel);
            BeginTransaction();
            var result = Service.Add(entity);
            Commit();
            if (result != default(TEntity))
                return Mapper.Map<TViewModel>(result);
            return null;
        }

        public TViewModel GetById(Guid id)
        {
            var result = Service.FindById(id);
            if (result != default(TEntity))
                return Mapper.Map<TViewModel>(result);
            return null;
        }

        public TViewModel Update(TViewModel viewModel)
        {
            var entity = Mapper.Map<TEntity>(viewModel);
            BeginTransaction();
            var result = Service.Update(entity);
            Commit();
            if (result != default(TEntity))
                return Mapper.Map<TViewModel>(result);
            return null;
        }

        public IEnumerable<TViewModel> GetAll()
        {
            var result = Service.GetAll();
            if (result != null)
                return Mapper.Map<IEnumerable<TViewModel>>(result);
            return null;
        }

        public void Remove(TViewModel viewModel)
        {
            var entity = Mapper.Map<TEntity>(viewModel);
            BeginTransaction();
            Service.Remove(entity);
            Commit();
        }
    }
}