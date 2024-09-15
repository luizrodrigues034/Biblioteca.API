using Bibiloteca.Aplication.Commands.RemoveCommands;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Biblioteca.API.Controllers
{
    [Route("api/emprestimo")]
    public class EmprestimoControllers :ControllerBase
    {
        private readonly IMediator _mediator;
        public EmprestimoControllers(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> MakeEmprestimo([FromBody] EmprestimoCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
