using Application.Contracts.Infrastructure;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuentaBloqueada.Commands.InsertCuentaBloqueada
{
    public class InsertCuentaBloqueadaCommandHandler : IRequestHandler<InsertCuentaBloqueadaCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InsertCuentaBloqueadaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(InsertCuentaBloqueadaCommand request, CancellationToken cancellationToken)
        {
            var cuentaBloqueada = _mapper.Map<CuentaBloqueada>(request);
            cuentaBloqueada.Archivo = await _unitOfWork.FileStorage.SaveFileAsync(request.Archivo);
            _unitOfWork.genericRepository<CuentaBloqueada>().Add(cuentaBloqueada);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
