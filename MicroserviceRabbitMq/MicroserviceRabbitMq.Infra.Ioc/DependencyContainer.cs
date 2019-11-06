using MediatR;
using MicroserviceRabbitMq.Banking.Application.Interfaces;
using MicroserviceRabbitMq.Banking.Application.Services;
using MicroserviceRabbitMq.Banking.Data.Context;
using MicroserviceRabbitMq.Banking.Data.Repository;
using MicroserviceRabbitMq.Banking.Domain.CommandHandlers;
using MicroserviceRabbitMq.Banking.Domain.Commands;
using MicroserviceRabbitMq.Banking.Domain.Interfaces;
using MicroserviceRabbitMq.Domain.Core.Bus;
using MicroserviceRabbitMq.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMq.Infra.Ioc
{
   public  class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application services
            services.AddTransient<IAccountService, AccountService>();

            //Data 
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<BankingDbContext>();


        }
    }
}
