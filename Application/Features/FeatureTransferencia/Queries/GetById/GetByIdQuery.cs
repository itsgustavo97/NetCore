using Application.Models;
using MediatR;

namespace Application.Features.FeatureTransferencia.Queries.GetById
{
    public class GetByIdQuery : IRequest<TransferenciaDto>
    {
        public long Id { get; set; }
        public GetByIdQuery(long Id)
        {
            this.Id = Id;
        }
    }
}
