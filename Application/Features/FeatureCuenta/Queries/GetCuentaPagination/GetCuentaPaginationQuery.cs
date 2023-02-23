using Application.Features.FeaturePagination.Queries;
using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeatureCuenta.Queries.GetCuentaPagination
{
    public class GetCuentaPaginationQuery : PaginationBaseQuery, IRequest<PaginationDto<CuentaDto>>
    {

    }
}
