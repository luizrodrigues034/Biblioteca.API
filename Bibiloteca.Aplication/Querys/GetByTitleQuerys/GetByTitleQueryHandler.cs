using Bibiloteca.Aplication.ViewModel;
using Biblioteca.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Querys.GetByTitleQuerys
{
    public class GetByTitleQueryHandler : IRequestHandler<GetByTitleQuery, LivroViewModel>
    {
        private readonly BibliotecaDbContext _dbContext;
        public GetByTitleQueryHandler(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<LivroViewModel> Handle(GetByTitleQuery request, CancellationToken cancellationToken)
        {
            var livros = await _dbContext.Livros.ToListAsync();
            
            var livro = livros.FirstOrDefault(p => p.Titulo == request.Title);
            return new LivroViewModel(livro.Titulo, livro.Autor, livro.Isbn, livro.DataPublicacao);

        }
    }
}
