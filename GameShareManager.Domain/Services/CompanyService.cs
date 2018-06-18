using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class CompanyService : BaseService<Company, CompanyFilter>, ICompanyService
    {
        public CompanyService(ICompanyRepository repository) : base(repository)
        {
        }

        public override DataTableResult<Company> GetDataTableResultByFilter(CompanyFilter filter)
        {
           return Repository.GetByFilter(filter);
        }
    }
}