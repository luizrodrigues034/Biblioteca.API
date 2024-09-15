using Bibiloteca.Aplication.Commands.CreateUserCommands;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] CreateUserCommand command )
        {
            var id = await _mediator.Send(command);
            return Created($"/api/users/{id}", new { id });

        }

    }
    
}
