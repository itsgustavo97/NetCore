using Application.Contracts.Infrastructure;
using Application.Exceptions;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureTransferencia.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, TransferenciaDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<TransferenciaDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.genericRepository<Transferencia>().GetByIdAsync(request.Id);
            if (result == null)
            {
                throw new NotFoundException(nameof(Transferencia), request.Id);
            }
            return mapper.Map<TransferenciaDto>(result);
        }
    }
}
