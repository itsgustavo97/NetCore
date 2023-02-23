using Application.Features.FeatureCuentaBloqueada.Commands.InsertCuentaBloqueada;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaBloqueadaController : MediaTrController
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post([FromForm] InsertCuentaBloqueadaCommand cuentaBloqueada) =>
            Ok(await _mediator.Send(cuentaBloqueada));
    }
}
