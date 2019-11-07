using MicroserviceRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMq.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        //TO get accounts
        IEnumerable<TransferLog> GetTransferLogs();
        
    }
}
