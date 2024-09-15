using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiloteca.Aplication.Commands.RemoveCommands
{
    public class RemoveCommand : IRequest<Unit>
    {
        public RemoveCommand(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
