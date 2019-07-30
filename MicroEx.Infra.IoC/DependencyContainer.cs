using MediatR;
using MicroEx.Banking.Application.Interfaces;
using MicroEx.Banking.Application.Services;
using MicroEx.Banking.Data.Context;
using MicroEx.Banking.Data.Repository;
using MicroEx.Banking.Domain.CommandHandlers;
using MicroEx.Banking.Domain.Commands;
using MicroEx.Banking.Domain.Interfaces;
using MicroEx.Domain.Core.Bus;
using MicroEx.Infra.Bus;
using MicroEx.Transfer.Application.Interfaces;
using MicroEx.Transfer.Application.Services;
using MicroEx.Transfer.Domain.Interfaces;
using MicroEx.Transfer.Data.Context;
using MicroEx.Transfer.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MicroEx.Transfer.Domain.Events;
using MicroEx.Transfer.Domain.EventHandlers;

namespace MicroEx.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();

            //Application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
