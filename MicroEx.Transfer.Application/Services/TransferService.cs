using MicroEx.Transfer.Application.Interfaces;
using MicroEx.Transfer.Domain.Interfaces;
using MicroEx.Transfer.Domain.Models;
using MicroEx.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

    }
}
