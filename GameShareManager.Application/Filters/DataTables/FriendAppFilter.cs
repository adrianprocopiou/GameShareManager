﻿using GameShareManager.Application.DataTables;

namespace GameShareManager.Application.Filters.DataTables
{
    public class FriendAppFilter : DataTableAjaxPostModel
    {
        public string Name { get; set; }
    }
}