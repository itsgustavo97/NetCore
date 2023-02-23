using Application.Constants;
using Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia;
using Application.Features.FeatureTransferencia.Queries.GetAll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class TransferenciaController : MediaTrController
    {
        [HttpPost]
        [Authorize(Roles = SystemRoles.Administrador)]
        public async Task<ActionResult> Post([FromBody] CreateTransferenciaCommand transfer) =>
            Ok(await _mediator.Send(transfer));

        [HttpGet("{Id:long}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetAll(long Id) =>
            Ok(await _mediator.Send(new GetAllQuery(Id)));
    }
}
