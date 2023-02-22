using Application.Models;
using MediatR;

namespace Application.Features.FeatureTransferencia.Queries.GetAll
{
    public class GetAllQuery : IRequest<List<TransferenciaDto>>
    {
    }
}
