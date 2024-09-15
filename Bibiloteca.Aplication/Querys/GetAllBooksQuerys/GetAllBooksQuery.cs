using Bibiloteca.Aplication.ViewModel;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Querys.GetAllBooksQuerys
{
    public class GetAllBooksQuery : IRequest<List<LivroViewModel>>
    {
        public GetAllBooksQuery(string query)
        {
            
        }

    }
}
