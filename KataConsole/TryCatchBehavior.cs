using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole
{
    public class TryCatchBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
        where TResponse : new()
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine($"request form try catch : {request.GetType().Name}");
            try
            {
                var result = await next();
            }
            catch
            {
                Console.WriteLine("catch");
            }
            
            return new TResponse();
        }
    }
}
