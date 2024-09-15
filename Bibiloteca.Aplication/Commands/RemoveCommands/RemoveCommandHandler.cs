using Biblioteca.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Commands.RemoveCommands
{
    public class RemoveCommandHandler : IRequestHandler<RemoveCommand, Unit>
    {
        private readonly BibliotecaDbContext _dbContext;
        public RemoveCommandHandler(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(RemoveCommand request, CancellationToken cancellationToken)
        {
            var listaLivros = await _dbContext.Livros.ToListAsync();
            var projetoAExcluir = listaLivros.SingleOrDefault(p => p.Titulo == request.Title);
            _dbContext.Livros.Remove(projetoAExcluir);
            await _dbContext.SaveChangesAsync();
            return Unit.Value;
            

        }
    }
}
