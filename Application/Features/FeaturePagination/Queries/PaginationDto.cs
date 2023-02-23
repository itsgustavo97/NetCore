using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeaturePagination.Queries
{
    public class PaginationDto<T> where T : class
    {
        public int Counter { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public IReadOnlyList<T> Data { get; set; }
        public int PageCounter { get; set; }
        public string Search { get; set; }
    }
}
