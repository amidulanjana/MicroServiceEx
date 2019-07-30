using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroEx.Transfer.Application.Interfaces;
using MicroEx.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroEx.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }


    }
}
