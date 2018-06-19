using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Repositories
{
    public interface IGameRepository : IRepository<Game, GameFilter>
    {
        DataTableResult<Game> GetLoansByFilter(GameFilter filter);
        DataTableResult<Game> GetAvailableByFilter(GameFilter filter);
        Select2Result<Game> GetSelect2OnlyAvailableFilter(int page, string term);
        Select2Result<Game> GetSelect2OnlyLoanFilter(int page, string term);

    }
}