using FluentValidation;

namespace Application.Features.FeatureCuenta.Commands.Insert
{
    public class InsertCommandValidator : AbstractValidator<InsertCommand>
    {
        public InsertCommandValidator()
        {
            RuleFor(p => p.NumeroCuenta).NotNull().WithMessage("No debe ser nulo");
            RuleFor(p => p.NumeroCuenta).NotEmpty().WithMessage("No debe estar vacío");
            //
            RuleFor(p => p.TipoCuenta).NotNull().WithMessage("No debe ser nulo");
            RuleFor(p => p.TipoCuenta).NotEmpty().WithMessage("No debe estar vacío");
            //
            RuleFor(p => p.Saldo).NotNull().WithMessage("No debe ser nulo");
            RuleFor(p => p.Saldo).NotEmpty().WithMessage("No debe estar vacío");
            RuleFor(p => p.Saldo).GreaterThan(0).WithMessage("Debe ser mayor a $0");
        }
    }
}
