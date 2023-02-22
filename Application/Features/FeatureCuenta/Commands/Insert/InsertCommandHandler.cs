using Application.Contracts.Infrastructure;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Commands.Insert
{
    public class InsertCommandHandler : IRequestHandler<InsertCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InsertCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(InsertCommand request, CancellationToken cancellationToken)
        {
            var cuenta = _mapper.Map<Cuenta>(request);
            _unitOfWork.genericRepository<Cuenta>().Add(cuenta);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
