using System.Linq;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Extension
{
    public static class DataTableResultExtension
    {
        public static DataTableResult<T> ToDataTableResult<T>(this IQueryable<T> source, int draw, int start, int length) where T : Entity
        {
            return new DataTableResult<T>(source,draw,start,length);
        }
    }
}