using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Domain.Services
{
    public class CompanyService : BaseService<Company>, ICompanyService
    {
        public CompanyService(ICompanyRepository repository) : base(repository)
        {
        }
    }
}