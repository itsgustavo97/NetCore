using Application.Models;
using MediatR;

namespace Application.Features.FeatureCuenta.Queries.GetAll
{
    public class GetAllQuery : IRequest<List<CuentaDto>>
    {

    }
}
