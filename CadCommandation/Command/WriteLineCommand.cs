using CadCommandation.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadCommandation.Command
{
    public class WriteLineCommand : IRequestHandler<WritLineRequest, bool>
    {
        Task<bool> IRequestHandler<WritLineRequest, bool>.Handle(WritLineRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine();
            return Task.FromResult(true);
        }
    }
}
