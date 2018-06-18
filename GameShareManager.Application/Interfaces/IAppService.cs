using System;
using System.Collections.Generic;
using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Interfaces
{
    public interface IAppService<TViewModel,TAppFilter>
        where TViewModel : class
        where TAppFilter : DataTableAjaxPostModel
    {
        TViewModel Add(TViewModel viewModel);
        TViewModel GetById(Guid id);
        TViewModel Update(TViewModel viewModel);
        IEnumerable<TViewModel> GetAll();
        DataTableResultApp<TViewModel> GetFilter(TAppFilter filter);
        void Remove(TViewModel viewModel);
    }
}