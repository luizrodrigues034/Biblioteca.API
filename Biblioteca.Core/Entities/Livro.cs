using Biblioteca.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Entities
{
    public class Livro : BaseEntity
    {
        public Livro(string titulo, string autor, string isbn, int dataPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            DataPublicacao = dataPublicacao;
            Status = EmprestimoStatus.Disponivel;
        }
        public string Titulo { get;  set; }
        public string Autor { get;  set; }
        public string Isbn { get; set; }
        public int DataPublicacao { get; set; }
        public EmprestimoStatus Status { get; set; }
        public void Emprestar()
        {
            if (Status == EmprestimoStatus.Disponivel)
            {
                Status = EmprestimoStatus.Emprestado;

            }
        }

    }
}
