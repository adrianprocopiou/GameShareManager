using System;
using GameShareManager.Application.DataTables;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Select2;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Application.Interfaces
{
    public interface IGameAppService: IAppService<GameViewModel, GameAppFilter>
    {
        void Loan(LoanViewModel loan);
        void GiveBack(Guid gameId);
        DataTableResultApp<GameViewModel> GetDataTableResultLoansByFilter(GameAppFilter filter);
        DataTableResultApp<GameViewModel> GetDataTableResultAvailableByFilter(GameAppFilter filter);
        Select2ResultApp<GameViewModel> GetSelect2OnlyAvailableFilter(int page, string term);
        Select2ResultApp<GameViewModel> GetSelect2OnlyLoanFilter(int page, string term);
    }
}