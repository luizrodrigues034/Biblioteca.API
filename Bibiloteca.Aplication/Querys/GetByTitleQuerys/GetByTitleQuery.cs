using Bibiloteca.Aplication.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Querys.GetByTitleQuerys
{
    public class GetByTitleQuery : IRequest<LivroViewModel>
    {
        public GetByTitleQuery(string title)
        {
            Title = title; 
        }
        public string Title { get; set; }
    }
}
