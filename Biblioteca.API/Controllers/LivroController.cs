using Bibiloteca.Aplication.Commands.CreateBookCommand;
using Bibiloteca.Aplication.Commands.RemoveCommands;
using Bibiloteca.Aplication.Querys.GetAllBooksQuerys;
using Bibiloteca.Aplication.Querys.GetByTitleQuerys;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/livros")]
public class LivroController : ControllerBase
{
    private readonly IMediator _mediator;
    public LivroController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("todos")]
    public async Task<IActionResult> GetAllBooks(string query)
    {
        var getByAll = new GetAllBooksQuery(query);
        var livros = await _mediator.Send(getByAll);
        
        return Ok(livros);
    }

    [HttpPost]
    public async Task<IActionResult> PostBook([FromBody] CreateBookCommand command)
    {
      
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetBook), new { id = id }, command);
    }


    [HttpGet("detalhes")]
    public async Task<IActionResult> GetBook(string title)
    {
        var getByTitle = new GetByTitleQuery(title);
        var livro = await _mediator.Send(getByTitle);
        return Ok(livro);
    }

    [HttpPost("remover")]
    public async Task<IActionResult> RemoveBook(string title)
    {
        var remover = new RemoveCommand(title);
        await _mediator.Send(remover);
        return Ok(title);
    }
}
