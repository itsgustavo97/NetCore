using Application.Models;
using MediatR;

namespace Application.Features.FeatureTransferencia.Queries.GetAll
{
    public class GetAllQuery : IRequest<IEnumerable<TransferenciaDto>>
    {
        public long Id { get; set; }
        public GetAllQuery(long Id)
        {
            this.Id = Id;
        }
    }
}
