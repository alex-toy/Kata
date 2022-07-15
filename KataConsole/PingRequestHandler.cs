using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole
{
    public class PingRequestHandler : IRequestHandler<PingRequest, PingResponse>
    {
        public Task<PingResponse> Handle(PingRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("ping");
            return Task.FromResult(new PingResponse());
        }
    }
}
