using Bibiloteca.Aplication.ViewModel;
using Biblioteca.Core.Entities;
using Biblioteca.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Querys.GetAllBooksQuerys
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<LivroViewModel>>
    {
        private readonly BibliotecaDbContext _dbContext;
        public GetAllBooksQueryHandler(BibliotecaDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<List<LivroViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
           var livrosLista = await _dbContext.Livros.ToListAsync();
           var livro = livrosLista.Select(p => new LivroViewModel(p.Titulo, p.Autor, p.Isbn, p.DataPublicacao)).ToList();
            return livro;
        }
    }
}
