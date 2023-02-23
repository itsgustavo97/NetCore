using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.FeatureCuentaBloqueada.Commands.InsertCuentaBloqueada
{
    public class InsertCuentaBloqueadaCommand : IRequest
    {
        public long IdCuenta { get; set; }
        public IFormFile Archivo { get; set; }
    }
}
