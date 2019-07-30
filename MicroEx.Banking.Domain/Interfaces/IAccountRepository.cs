using MicroEx.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
