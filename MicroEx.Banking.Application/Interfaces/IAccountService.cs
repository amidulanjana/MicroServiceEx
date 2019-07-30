using MicroEx.Banking.Application.Models;
using MicroEx.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
