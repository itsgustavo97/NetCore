using FluentValidation;

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
            RuleFor(p => p.Saldo).GreaterThan(0).WithMessage("Debe ser mayor a $0");
        }
    }
}
