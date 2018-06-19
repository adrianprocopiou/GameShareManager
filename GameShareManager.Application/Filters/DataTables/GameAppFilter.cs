using System;
using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters.DataTables
{
    public class GameAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}