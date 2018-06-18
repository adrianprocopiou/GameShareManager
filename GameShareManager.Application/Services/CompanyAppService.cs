using GameShareManager.Application.Filters;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class CompanyAppService : BaseAppService<Company,CompanyViewModel,CompanyFilter,CompanyAppFilter,GameShareManagerContext>, ICompanyAppService
    {
        public CompanyAppService(IUnitOfWork<GameShareManagerContext> uow, ICompanyService service) : base(uow, service)
        {
        }
    }
}