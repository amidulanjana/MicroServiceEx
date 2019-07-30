using MicroEx.Banking.Application.Interfaces;
using MicroEx.Banking.Application.Models;
using MicroEx.Banking.Domain.Commands;
using MicroEx.Banking.Domain.Interfaces;
using MicroEx.Banking.Domain.Models;
using MicroEx.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
