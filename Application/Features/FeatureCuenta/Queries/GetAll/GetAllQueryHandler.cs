using Application.Contracts.Infrastructure;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<CuentaDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<CuentaDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.genericRepository<Cuenta>().GetAllActiveAsync();
            return _mapper.Map<List<CuentaDto>>(list);
        }
    }
}
