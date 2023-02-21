using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MediaTrController : ControllerBase
    {
        private IMediator mediator;
        protected IMediator _mediator => mediator ?? (mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}
