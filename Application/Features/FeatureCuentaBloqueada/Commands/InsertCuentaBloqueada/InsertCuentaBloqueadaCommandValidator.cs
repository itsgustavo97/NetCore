using FluentValidation;

namespace Application.Features.FeatureCuentaBloqueada.Commands.InsertCuentaBloqueada
{
    public class InsertCuentaBloqueadaCommandValidator : AbstractValidator<InsertCuentaBloqueadaCommand>
    {
        public InsertCuentaBloqueadaCommandValidator()
        {
            RuleFor(p => p.Archivo).NotNull().WithMessage("No debe ser nulo");
            RuleFor(p => p.Archivo).NotEmpty().WithMessage("No debe estar vacío");
        }
    }
}
