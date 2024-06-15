using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolucionesRecidencilaes.Application.Queries;

namespace SolucionesRecidenciales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CreateClienteCommand")]
        public async Task<IActionResult> CreateCliente(CreateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
