﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Specification
{
    public abstract class SpecificationParams
    {
        public string Search { get; set; }
        public string Sort { get; set; }
        public int PageIndex { get; set; } = 1;

        private const int MaxPageSize = 50;
        private int _pageSize = 3;
        public int PageSize { get => _pageSize; set => _pageSize = (value > MaxPageSize)? MaxPageSize : value; }
    }
}
