using Application.Constants;
using Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TransferenciaController : MediaTrController
    {
        [HttpPost]
        [Authorize(Roles = SystemRoles.Administrador)]
        public async Task<ActionResult> Post([FromBody] CreateTransferenciaCommand transfer) =>
            Ok(await _mediator.Send(transfer));
    }
}
