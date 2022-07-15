// See https://aka.ms/new-console-template for more information
using KataConsole;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>  services
        .AddMediatR(typeof(Program))
        .AddTransient(typeof(IPipelineBehavior<,>), typeof(LogBehavior<,>))
        .AddTransient(typeof(IPipelineBehavior<,>), typeof(TryCatchBehavior<,>)))
    .Build();

IMediator mediator = host.Services.GetService<IMediator>();
PingResponse response = await mediator.Send(new PingRequest());

