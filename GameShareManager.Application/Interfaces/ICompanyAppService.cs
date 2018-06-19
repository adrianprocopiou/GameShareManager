using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Application.Interfaces
{
    public interface ICompanyAppService: IAppService<CompanyViewModel,CompanyAppFilter>
    {
    }
}