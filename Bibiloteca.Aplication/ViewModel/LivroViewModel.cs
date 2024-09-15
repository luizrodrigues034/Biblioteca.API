using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.ViewModel
{
    public class LivroViewModel
    {
        public LivroViewModel(string titulo, string autor, string isbn, int dataPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            DataPublicacao = dataPublicacao;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public int DataPublicacao { get; set; }
    }
}
