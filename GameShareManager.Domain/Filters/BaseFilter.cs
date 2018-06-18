using System.Collections.Generic;

namespace GameShareManager.Domain.Filters
{
    public abstract class BaseFilter
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Order> order { get; set; }
    }
}