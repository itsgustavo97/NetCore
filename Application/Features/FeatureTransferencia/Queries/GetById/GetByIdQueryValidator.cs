using FluentValidation;

namespace Application.Features.FeatureTransferencia.Queries.GetById
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(p => p.Id).NotNull().WithMessage("no debe ser nulo");
        }
    }
}
