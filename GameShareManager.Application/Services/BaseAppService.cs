using System;
using System.Collections.Generic;
using AutoMapper;
using GameShareManager.Application.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public abstract class BaseAppService<TEntity, TViewModel, TFilter, TAppFilter, TContext> : UnitOfWorkService<TContext>, IAppService<TViewModel, TAppFilter>
        where TContext : IDbContext
        where TEntity : Entity
        where TViewModel : class
        where TFilter : BaseFilter
        where TAppFilter : DataTableAjaxPostModel


    {
        protected readonly IService<TEntity, TFilter> Service;

        protected BaseAppService(IUnitOfWork<TContext> uow, IService<TEntity, TFilter> service) : base(uow)
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

        public DataTableResultApp<TViewModel> GetFilter(TAppFilter filter)
        {
            var resultService = Service.GetDataTableResultByFilter(Mapper.Map<TFilter>(filter));
            return new DataTableResultApp<TViewModel>(resultService.draw, resultService.start, resultService.length, resultService.recordsTotal, Mapper.Map<List<TViewModel>>(resultService.data), resultService.recordsFiltered);
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