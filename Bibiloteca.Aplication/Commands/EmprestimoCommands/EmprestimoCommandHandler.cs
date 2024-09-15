using Biblioteca.Core.Entities;
using Biblioteca.Core.Enums;
using Biblioteca.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

public class EmprestimoCommandHandler : IRequestHandler<EmprestimoCommand, Unit>
{
    private readonly BibliotecaDbContext _context;

    public EmprestimoCommandHandler(BibliotecaDbContext context)
    {
        _context = context;
    }
    public async Task<Unit> Handle(EmprestimoCommand request, CancellationToken cancellationToken)
    {

        var emprestimo = new Emprestimo(request.IdUser, request.IdLivro);

        var livro = await _context.Livros.FirstOrDefaultAsync(p => p.Id == request.IdLivro);

        await _context.Emprestimos.AddAsync(emprestimo);
        
        livro.Status = EmprestimoStatus.Emprestado;
        await _context.AddAsync(emprestimo);
        await _context.SaveChangesAsync();
        return Unit.Value;
    }
}
