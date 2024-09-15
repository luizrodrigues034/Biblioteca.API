using Biblioteca.Core.Entities;
using MediatR;

public class EmprestimoCommand: IRequest<Unit>
{
    public EmprestimoCommand(int idUser, int idLivro)
    {
        IdUser = idUser;
        IdLivro = idLivro;
    }
    public int IdUser { get; }
    public int IdLivro { get; }
}
