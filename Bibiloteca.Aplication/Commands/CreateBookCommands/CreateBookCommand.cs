using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Bibiloteca.Aplication.Commands.CreateBookCommand
{
    public class CreateBookCommand : IRequest<int>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public int DataPublicacao { get; set; }
    }
}
