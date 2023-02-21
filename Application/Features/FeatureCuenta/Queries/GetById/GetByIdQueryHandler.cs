using Application.Contracts.Infrastructure;
using Application.Exceptions;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, CuentaDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<CuentaDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.genericRepository<Cuenta>().GetByIdAsync(request.Id);
            if (result == null)
            {
                throw new NotFoundException(nameof(Cuenta), request.Id);
            }
            return mapper.Map<CuentaDto>(result);
        }
    }
}
