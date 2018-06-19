using System;

namespace GameShareManager.Domain.Filters
{
    public class GameFilter : BaseFilter
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public Guid FrienId { get; set; }
    }
}