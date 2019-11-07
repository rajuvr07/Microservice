using MicroserviceRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMq.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        void Add(TransferLog transferLog);
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
