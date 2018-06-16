﻿using System;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        /// <summary>
        /// Store object into database
        /// </summary>
        /// <param name="obj">Object to be stored</param>
        /// <returns></returns>
        T Add(T obj);

        /// <summary>
        /// Retrieves the object with specified id from database
        /// </summary>
        /// <param name="id">The id sent to retrieve object</param>
        /// <returns></returns>
        T FindById(Guid id);

        /// <summary>
        /// Update the sent object
        /// </summary>
        /// <param name="obj">Object to be updated</param>
        /// <returns></returns>
        T Update(T obj);

        /// <summary>
        /// Remove the sent object from database
        /// </summary>
        /// <param name="obj">Object to be removed</param>
        void Remove(T obj);
    }
}