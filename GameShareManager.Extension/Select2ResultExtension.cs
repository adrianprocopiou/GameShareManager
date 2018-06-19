using System.Linq;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Extension
{
    public static class Select2ResultExtension
    {
        public static Select2Result<T> ToSelect2Result<T>(this IQueryable<T> source, int page) where T : Entity
        {
            return new Select2Result<T>(source,page);
        }
    }
}