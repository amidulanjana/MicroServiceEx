using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Domain.Commands
{
    public class CreateTransferCommand : TrnasferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
