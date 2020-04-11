using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ocelot_gateway.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/home
        [Route("api/homme")]
        [HttpGet]
        public string Get()
        {
            return "明源的网关";
        }
    }
}