using Application.Contracts.Infrastructure;
using Application.Exceptions;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia
{
    public class CreateTransferenciaCommandHandler : IRequestHandler<CreateTransferenciaCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTransferenciaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTransferenciaCommand request, CancellationToken cancellationToken)
        {
            using (var transaction = await _unitOfWork.BeginTransactionAsync())
            {
                var cuentaOrigen = await _unitOfWork.genericRepository<Cuenta>().GetByIdAsync(request.IdCuentaOrigen);
                var cuentaDestino = await _unitOfWork.genericRepository<Cuenta>().GetByIdAsync(request.IdCuentaDestino);
                if (cuentaOrigen == null)
                    throw new NotFoundException(nameof(Cuenta), request.IdCuentaOrigen);
                if(cuentaDestino == null)
                    throw new NotFoundException(nameof(Cuenta), request.IdCuentaDestino);
                if (cuentaOrigen.Saldo < request.Monto)
                    throw new BadRequestException(nameof(Cuenta));
                var transfer = _mapper.Map<Transferencia>(request);
                cuentaOrigen.Saldo = cuentaOrigen.Saldo - request.Monto; 
                cuentaDestino.Saldo = cuentaDestino.Saldo + request.Monto;
                _unitOfWork.genericRepository<Cuenta>().Update(cuentaOrigen);
                _unitOfWork.genericRepository<Cuenta>().Update(cuentaDestino);
                _unitOfWork.genericRepository<Transferencia>().Add(transfer);
                await _unitOfWork.SaveChangesAsync();
                await transaction.CommitAsync();
                return Unit.Value;
            }
        }
    }
}
