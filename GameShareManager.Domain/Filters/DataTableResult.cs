using System.Collections.Generic;
using System.Linq;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Domain.Filters
{
    public class DataTableResult<TEntity> where TEntity:Entity
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }

        public List<TEntity> data { get; }

        public DataTableResult(IQueryable<TEntity> source, int draw, int start, int length)
        {
            this.draw = draw;
            this.start = start;
            this.length = length;
            this.recordsTotal = source.Count();
            this.data = source.Skip(start).Take(length).ToList();
            this.recordsFiltered = data.Count;
        }
    }
}