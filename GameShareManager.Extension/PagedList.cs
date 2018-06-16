using System.Collections.Generic;
using System.Linq;
// TODO: REMOVER O REALPAGE
namespace GameShareManager.Extension
{
    public class PagedList<T> : List<T>
    {
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int RealPage { get; set; }

        public PagedList(IQueryable<T> source, int page, int pageSize, bool all)
        {
            TotalCount = source.Count();
            Page = !all ? (page < 1 ? 0 : page - 1) : 0;
            RealPage = !all ? page : 0;
            PageSize = !all ? pageSize : TotalCount;
            PageCount = GetPageCount(PageSize, TotalCount);
            AddRange(source.Skip(Page * PageSize).Take(PageSize).ToList());
        }

        private static int GetPageCount(int pageSize, int totalCount)
        {
            if (pageSize == 0)
                return 0;

            var remainder = totalCount % pageSize;
            return (totalCount / pageSize) + (remainder == 0 ? 0 : 1);
        }

    }
}