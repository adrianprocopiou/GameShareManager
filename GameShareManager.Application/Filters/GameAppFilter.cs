using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters
{
    public class GameAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
    }
}