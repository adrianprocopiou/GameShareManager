using System;

namespace GameShareManager.Application.Interfaces
{
    public interface IAppService<TViewModel> where TViewModel : class
    {
        TViewModel Add(TViewModel viewModel);
        TViewModel GetById(Guid id);
        TViewModel Update(TViewModel viewModel);
        void Remove(TViewModel viewModel);
    }
}