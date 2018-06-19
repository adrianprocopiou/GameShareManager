using System;
using System.Collections.Generic;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity,TFilter> 
        where TEntity : Entity
        where TFilter : BaseFilter
    {
        /// <summary>
        /// Store object into database
        /// </summary>
        /// <param name="obj">Object to be stored</param>
        /// <returns></returns>
        TEntity Add(TEntity obj);

        /// <summary>
        /// Retrieves the object with specified id from database
        /// </summary>
        /// <param name="id">The id sent to retrieve object</param>
        /// <returns></returns>
        TEntity FindById(Guid id);

        /// <summary>
        /// Update the sent object
        /// </summary>
        /// <param name="obj">Object to be updated</param>
        /// <returns></returns>
        TEntity Update(TEntity obj);

        /// <summary>
        /// Remove the sent object from database
        /// </summary>
        /// <param name="obj">Object to be removed</param>
        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();
        DataTableResult<TEntity> GetByFilter(TFilter filter);
        Select2Result<TEntity> GetSelect2Filter(int page, string term);
    }
}