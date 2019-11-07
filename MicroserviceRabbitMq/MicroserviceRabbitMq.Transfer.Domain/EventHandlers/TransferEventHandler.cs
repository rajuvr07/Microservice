using MicroserviceRabbitMq.Domain.Core.Bus;
using MicroserviceRabbitMq.Transfer.Domain.Events;
using MicroserviceRabbitMq.Transfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceRabbitMq.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new Models.TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount

            });
          return  Task.CompletedTask;
        }
    }
}
