using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeaturePagination.Queries
{
    public class PaginationBaseQuery
    {
        public string Search { get; set; }
        public string SortBy { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
