using MicroEx.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroEx.Banking.Domain.Commands
{
    public abstract class TrnasferCommand : Command
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
