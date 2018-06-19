using System;
using System.Linq;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Extension;

namespace GameShareManager.Data.Repositories
{
    public class CompanyRepository : BaseRepository<Company, CompanyFilter>, ICompanyRepository
    {
        public CompanyRepository(IDbContext context) : base(context)
        {
        }

        public override DataTableResult<Company> GetByFilter(CompanyFilter filter)
        {
            var companies = DbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                companies = companies.Where(c => c.Name.Trim().ToLower().Contains(filter.Name.Trim().ToLower()));
            }

            
            companies = filter.order.Any(o=>o.dir == "DESC") ? companies.OrderByDescending(x => x.Name) : companies.OrderBy(x => x.Name);
            

            return companies.ToDataTableResult(filter.draw,filter.start,filter.length);
        }

        public override Select2Result<Company> GetSelect2Filter(int page, string term)
        {
            var companies = DbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(term))
                companies = companies.Where(x => x.Name.Trim().ToLower().Contains(term.Trim().ToLower()));

            companies = companies.OrderBy(x => x.Name);

            return companies.ToSelect2Result(page);
        }
    }
}