using Bibiloteca.Aplication.Commands.CreateBookCommand;
using Biblioteca.Core.Entities;
using Biblioteca.Infra;
using MediatR;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly BibliotecaDbContext _dbContext;
    public CreateBookCommandHandler(BibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var book = new Livro(request.Titulo, request.Autor, request.Isbn, request.DataPublicacao);
        await _dbContext.Livros.AddAsync(book);
        await _dbContext.SaveChangesAsync();

        return book.Id;
    }
}
