using Application.Models;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetById
{
    public class GetByIdQuery : IRequest<CuentaDto>
    {
        public long Id { get; set; }
        public GetByIdQuery(long Id)
        {
            this.Id = Id;
        }
    }
}
