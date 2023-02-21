using FluentValidation;

namespace Application.Features.FeatureCuenta.Queries.GetById
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(p => p.Id).NotNull().WithMessage("no debe ser nulo");
        }
    }
}
