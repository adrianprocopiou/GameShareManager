﻿using System.Collections.Generic;
using System.Linq;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Domain.Filters
{
    public class Select2Result <TEntity> where TEntity : Entity
    {
        private const int PageSize = 20;

        public int total_count;
        public List<TEntity> result;

        public Select2Result(IQueryable<TEntity> source, int page)
        {
            this.total_count = source.Count();
            this.result = source.Skip(PageSize * page).Take(PageSize).ToList();
        }
    }
}