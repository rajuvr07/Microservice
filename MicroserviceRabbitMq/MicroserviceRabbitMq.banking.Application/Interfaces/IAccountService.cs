using MicroserviceRabbitMq.Banking.Application.Models;
using MicroserviceRabbitMq.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        //TO get accounts
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
