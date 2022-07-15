using MediatR;

namespace KataConsole
{
    public class BuggyHandler : IRequestHandler<PingRequest, PingResponse>
    {
        public async Task<PingResponse> Handle(PingRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("buggy");
            return new PingResponse();
        }
    }
}
