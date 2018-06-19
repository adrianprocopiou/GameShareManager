using System;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Domain.Interfaces.Services
{
    public interface IGameService : IService<Game, GameFilter>
    {
        void Loan(Loan loan);
        DataTableResult<Game> GetDataTableResultLoansByFilter(GameFilter filter);
        DataTableResult<Game> GetDataTableResultAvailableByFilter(GameFilter filter);
        Select2Result<Game> GetSelect2OnlyAvailableFilter(int page, string term);
        Select2Result<Game> GetSelect2OnlyLoanFilter(int page, string term);
        void GiveBack(Guid gameId);
    }
}