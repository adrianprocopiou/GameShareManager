using System;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;
using GameShareManager.Domain.Interfaces.Repositories;
using GameShareManager.Domain.Interfaces.Services;
using GameShareManager.Resource;

namespace GameShareManager.Domain.Services
{
    public class GameService : BaseService<Game, GameFilter>, IGameService
    {
        private readonly IGameRepository _repository;
        private readonly IFriendRepository _friendRepository;
        public GameService(IGameRepository repository, IFriendRepository friendRepository) : base(repository)
        {
            _repository = repository;
            _friendRepository = friendRepository;
        }

        public void Loan(Loan loan)
        {
            var game = FindById(loan.GameId);
            if (game == default(Game)) throw new ArgumentException(Language.ArgumentInvalid, nameof(loan.GameId));

            var friend = _friendRepository.FindById(loan.FriendId);
            if (friend == default(Friend)) throw new ArgumentException(Language.ArgumentInvalid, nameof(loan.FriendId));

            game.FriendId = friend.Id;
            Update(game);
        }

        public DataTableResult<Game> GetDataTableResultLoansByFilter(GameFilter filter)
        {
            return _repository.GetLoansByFilter(filter);
        }

        public DataTableResult<Game> GetDataTableResultAvailableByFilter(GameFilter filter)
        {
            return _repository.GetAvailableByFilter(filter);
        }

        public Select2Result<Game> GetSelect2OnlyAvailableFilter(int page, string term)
        {
            return _repository.GetSelect2OnlyAvailableFilter(page, term);
        }

        public Select2Result<Game> GetSelect2OnlyLoanFilter(int page, string term)
        {
            return _repository.GetSelect2OnlyLoanFilter(page, term);
        }

        public void GiveBack(Guid gameId)
        {
            var game = FindById(gameId);
            if (game == default(Game)) throw new ArgumentException(Language.ArgumentInvalid, nameof(gameId));

            game.FriendId = null;
            Update(game);
        }
    }
}