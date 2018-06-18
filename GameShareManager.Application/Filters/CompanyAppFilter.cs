using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters
{
    public class CompanyAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
    }
}