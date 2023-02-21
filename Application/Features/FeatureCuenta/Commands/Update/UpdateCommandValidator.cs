using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeatureCuenta.Commands.Update
{
    public class UpdateCommandValidator : AbstractValidator<UpdateCommand>
    {
        public UpdateCommandValidator()
        {
            //Regla para Numero de cuenta
            RuleFor(p => p.NumeroCuenta).NotNull().WithMessage("No puede ser nulo");
            RuleFor(p => p.NumeroCuenta).NotEmpty().WithMessage("No puede estar vacío");
            //Regla para Tipo de cuenta
            RuleFor(p => p.TipoCuenta).NotNull().WithMessage("No puede ser nulo");
            RuleFor(p => p.TipoCuenta).NotEmpty().WithMessage("No puede estar vacío");
            //Regla para Saldo de cuenta
            RuleFor(p => p.Saldo).NotNull().WithMessage("No puede ser nulo");
            RuleFor(p => p.Saldo).NotEmpty().WithMessage("No puede estar vacío");
            RuleFor(p => p.Saldo).GreaterThanOrEqualTo(0).WithMessage("No puede menor o igual a $0");
        }
    }
}
