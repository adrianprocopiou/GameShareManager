namespace GameShareManager.Filter
{
    public class BaseFilter
    {
        public long Page { get; set; } = 0;
        public long PageSize { get; set; } = 10;
        public FilterSort Sort { get; set; } = FilterSort.Ascending;
    }
}