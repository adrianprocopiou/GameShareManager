using System;
using System.Collections.Generic;

namespace GameShareManager.Application.Interfaces
{
    public interface IAppService<TViewModel> where TViewModel : class
    {
        TViewModel Add(TViewModel viewModel);
        TViewModel GetById(Guid id);
        TViewModel Update(TViewModel viewModel);
        IEnumerable<TViewModel> GetAll();
        void Remove(TViewModel viewModel);
    }
}