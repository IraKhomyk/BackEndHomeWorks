using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeWorkDI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        Client client = new Client();


        [HttpGet]
        public string Get()
        {
            client.TicketNumber = "BK12345";
            return client.TicketNumber;
        }

    }
}
