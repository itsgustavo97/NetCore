using Application.Features.FeatureCuenta.Commands.Insert;
using Application.Features.FeatureCuenta.Commands.Update;
using Application.Features.FeatureCuenta.Queries.GetAll;
using Application.Features.FeatureCuenta.Queries.GetById;
using Application.Features.FeatureCuenta.Queries.GetCuentaPagination;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CuentaController : MediaTrController
    {
        [HttpGet]
        public async Task<ActionResult<List<CuentaDto>>> Get() =>
            Ok(await _mediator.Send(new GetAllQuery()));

        [HttpGet("Id")]
        public async Task<ActionResult<CuentaDto>> GetById(long Id) =>
            Ok(await _mediator.Send(new GetByIdQuery(Id)));

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] InsertCommand cuenta) =>
            Ok(await _mediator.Send(cuenta));

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCommand cuenta) =>
            Ok(await _mediator.Send(cuenta));
        [HttpGet("Pagination")]
        [AllowAnonymous]
        public async Task<ActionResult> GetPagination([FromQuery] GetCuentaPaginationQuery query) =>
            Ok(await _mediator.Send(query));
    }
}
