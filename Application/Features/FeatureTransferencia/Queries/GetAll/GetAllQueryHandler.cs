using Application.Contracts.Infrastructure;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureTransferencia.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<TransferenciaDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<TransferenciaDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            //TODO: hacer usp con Dapper
            

            var list = await _unitOfWork.genericRepository<Transferencia>().GetAllActiveAsync();
            return _mapper.Map<List<TransferenciaDto>>(list);
        }
    }
}
