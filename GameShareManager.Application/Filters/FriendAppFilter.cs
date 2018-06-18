using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters
{
    public class FriendAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
    }
}