using Application.Contracts.Infrastructure;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<CuentaDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<CuentaDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.genericRepository<Cuenta>().GetAllActiveAsync();
            return mapper.Map<List<CuentaDto>>(list);
        }
    }
}
