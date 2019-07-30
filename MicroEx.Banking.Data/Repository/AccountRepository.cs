using MicroEx.Banking.Data.Context;
using MicroEx.Banking.Domain.Interfaces;
using MicroEx.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
