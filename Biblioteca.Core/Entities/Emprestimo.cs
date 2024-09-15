using Biblioteca.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Entities
{
    public class Emprestimo : BaseEntity
    {
        public Emprestimo(int idUser, int idLivro)
        {
            IdUser = idUser;
            IdLivro = idLivro;
            DataEmpretimo = DateTime.Now;
            
        }

        public int IdUser { get; }
        public int IdLivro { get; }
        public User User { get; private set; }
        public Livro Livro { get; private set; }
        public DateTime DataEmpretimo { get; }
        
        
    }
}
