using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia
{
    public class CreateTransferenciaCommandValidator : AbstractValidator<CreateTransferenciaCommand>
    {
        public CreateTransferenciaCommandValidator()
        {
            //Reglas de validacion para IdCuentaOrigen
            RuleFor(p => p.IdCuentaOrigen).NotNull().WithMessage("no debe ser nulo");
            RuleFor(p => p.IdCuentaOrigen).NotEmpty().WithMessage("no debe ser vacío");
            //Reglas de validacion para IdCuentaDestino
            RuleFor(p => p.IdCuentaDestino).NotNull().WithMessage("no debe ser nulo");
            RuleFor(p => p.IdCuentaDestino).NotEmpty().WithMessage("no debe ser vacío");
            //Reglas de validacion para Motivo
            RuleFor(p => p.Motivo).NotNull().WithMessage("no debe ser nulo");
            RuleFor(p => p.Motivo).NotEmpty().WithMessage("no debe ser vacío");
            //Reglas de validacion para Monto
            RuleFor(p => p.Monto).NotNull().NotEmpty().WithMessage("no debe ser nulo");
            RuleFor(p => p.Monto).NotNull().NotEmpty().WithMessage("no debe ser vacío");
            RuleFor(p => p.Monto).GreaterThan(0).WithMessage("El valor debe ser mayor a 0");
        }
    }
}
