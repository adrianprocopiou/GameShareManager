using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Repositories
{
    public interface ICompanyRepository : IRepository<Company,CompanyFilter>
    {
        
    }
}