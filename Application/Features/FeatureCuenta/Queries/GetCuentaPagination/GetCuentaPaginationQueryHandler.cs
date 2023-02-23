using Application.Contracts.Infrastructure;
using Application.Features.FeaturePagination.Queries;
using Application.Models;
using Application.Specification.CuentaSpecification;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetCuentaPagination
{
    public class GetCuentaPaginationQueryHandler : IRequestHandler<GetCuentaPaginationQuery, PaginationDto<CuentaDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCuentaPaginationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PaginationDto<CuentaDto>> Handle(GetCuentaPaginationQuery request, CancellationToken cancellationToken)
        {
            var specification = _mapper.Map<CuentaPaginationParams>(request);
            var specCount = new CuentaPaginationCount(specification);
            var totalData = await _unitOfWork.genericRepository<Cuenta>().CountAsync(specCount);
            var specPagination = new CuentaPagination(specification);
            var datos = await _unitOfWork.genericRepository<Cuenta>().GetAllWithSpecAsync(specPagination);
            var round = Math.Ceiling(Convert.ToDecimal(totalData) / Convert.ToDecimal(request.PageSize));
            var totalPaginas = Convert.ToInt32(round);
            var list = _mapper.Map<IReadOnlyList<CuentaDto>>(datos);
            return new PaginationDto<CuentaDto> { 
                Data= list, 
                Counter = totalData, 
                PageCounter = totalPaginas, 
                PageIndex = request.PageIndex, 
                PageSize = request.PageSize, 
                Search = request.Search 
            };
        }
    }
}
