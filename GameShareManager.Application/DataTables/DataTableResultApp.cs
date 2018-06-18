using System.Collections.Generic;
using AutoMapper;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Application.DataTables
{
    public class DataTableResultApp<TViewModel>
    {
        public int draw { get; }
        public int start { get; }
        public int length { get; }
        public int recordsTotal { get; }

        public int recordsFiltered { get; }

        public List<TViewModel> data { get; }

        public DataTableResultApp(int draw, int start, int length, int recordsTotal, List<TViewModel> data, int recordsFiltered)
        {
            this.draw = draw;
            this.start = start;
            this.length = length;
            this.recordsTotal = recordsTotal;
            this.data = data;
            this.recordsFiltered = recordsFiltered;
        }

    }
}