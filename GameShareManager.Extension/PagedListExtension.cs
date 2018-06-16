using System.Linq;

namespace GameShareManager.Extension
{
    public static class PagedListExtension
    {
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, int page, int pageSize, bool all)
        {
            return new PagedList<T>(source, page, pageSize, all);
        }
    }
}