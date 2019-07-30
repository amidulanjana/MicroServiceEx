using MicroEx.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
