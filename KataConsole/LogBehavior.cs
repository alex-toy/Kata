using log4net;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole
{
    public class LogBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        public LogBehavior(ILog logger)
        {
            Logger = logger;
        }

        public ILog Logger { get; }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Logger.Info($"request : {request.GetType().Name}");
            var result = await next();
            Logger.Info($"reult type : {result.GetType().Name}");
            return result;
        }
    }
}
