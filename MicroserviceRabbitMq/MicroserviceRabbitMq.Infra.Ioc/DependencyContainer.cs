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
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
