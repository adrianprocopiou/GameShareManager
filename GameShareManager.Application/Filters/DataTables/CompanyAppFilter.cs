﻿using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters.DataTables
{
    public class CompanyAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
    }
}