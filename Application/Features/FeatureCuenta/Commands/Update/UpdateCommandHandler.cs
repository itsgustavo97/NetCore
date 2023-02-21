using Application.Contracts.Infrastructure;
using Application.Exceptions;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.FeatureCuenta.Commands.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var cuentaToUpdate = await _unitOfWork.genericRepository<Cuenta>().GetByIdAsync(request.Id);
            if (cuentaToUpdate == null)
                throw new NotFoundException(nameof(Cuenta), request.Id);
            _mapper.Map(request, cuentaToUpdate, typeof(UpdateCommand), typeof(Cuenta));
            _unitOfWork.genericRepository<Cuenta>().Update(cuentaToUpdate);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
