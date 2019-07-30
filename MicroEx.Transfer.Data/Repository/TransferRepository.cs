using MicroEx.Transfer.Data.Context;
using MicroEx.Transfer.Domain.Interfaces;
using MicroEx.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.Add(transferLog);
            _ctx.SaveChanges();
        }
    }
}
