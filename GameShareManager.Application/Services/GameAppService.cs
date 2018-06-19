using System;
using System.Collections.Generic;
using AutoMapper;
using GameShareManager.Application.DataTables;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.Select2;
using GameShareManager.Application.ViewModels;
using GameShareManager.Data.Context;
using GameShareManager.Data.Interfaces;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Services;

namespace GameShareManager.Application.Services
{
    public class GameAppService : BaseAppService<Game, GameViewModel, GameFilter, GameAppFilter, GameShareManagerContext>, IGameAppService
    {
        private readonly IGameService _service;
        public GameAppService(IUnitOfWork<GameShareManagerContext> uow, IGameService service) : base(uow, service)
        {
            _service = service;
        }

        public void Loan(LoanViewModel loan)
        {
            BeginTransaction();
            _service.Loan(Mapper.Map<Loan>(loan));
            Commit();
        }

        public void GiveBack(Guid gameId)
        {
            BeginTransaction();
            _service.GiveBack(gameId);
            Commit();
        }

        public DataTableResultApp<GameViewModel> GetDataTableResultLoansByFilter(GameAppFilter filter)
        {
            var resultService = _service.GetDataTableResultLoansByFilter(Mapper.Map<GameFilter>(filter));
            return new DataTableResultApp<GameViewModel>(resultService.draw, resultService.start, resultService.length, resultService.recordsTotal, Mapper.Map<List<GameViewModel>>(resultService.data), resultService.recordsFiltered);
        }

        public DataTableResultApp<GameViewModel> GetDataTableResultAvailableByFilter(GameAppFilter filter)
        {
            var resultService = _service.GetDataTableResultAvailableByFilter(Mapper.Map<GameFilter>(filter));
            return new DataTableResultApp<GameViewModel>(resultService.draw, resultService.start, resultService.length, resultService.recordsTotal, Mapper.Map<List<GameViewModel>>(resultService.data), resultService.recordsFiltered);
        }

        public Select2ResultApp<GameViewModel> GetSelect2OnlyAvailableFilter(int page, string term)
        {
            var resultService = _service.GetSelect2OnlyAvailableFilter(page, term);
            return new Select2ResultApp<GameViewModel>(resultService.total_count, Mapper.Map<List<GameViewModel>>(resultService.result));
        }

        public Select2ResultApp<GameViewModel> GetSelect2OnlyLoanFilter(int page, string term)
        {
            var resultService = _service.GetSelect2OnlyLoanFilter(page, term);
            return new Select2ResultApp<GameViewModel>(resultService.total_count, Mapper.Map<List<GameViewModel>>(resultService.result));
        }
    }
}