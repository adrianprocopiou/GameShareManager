using System;
using System.Collections.Generic;
using GameShareManager.Application.DataTables;
using GameShareManager.Application.Select2;

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
        Select2ResultApp<TViewModel> GetSelect2Filter(int page, string term);
        void Remove(TViewModel viewModel);
    }
}