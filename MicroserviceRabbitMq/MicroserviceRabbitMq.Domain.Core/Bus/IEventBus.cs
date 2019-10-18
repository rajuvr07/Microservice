﻿using MicroserviceRabbitMq.Domain.Core.Commands;
using MicroserviceRabbitMq.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMq.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

            void Publish<T>(Task @event) where T: Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;

    }
}
