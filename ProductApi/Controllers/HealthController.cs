using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_api.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET: api/Product
        [Route("api/health")]
        [HttpGet]
        public void Get()
        {
            return;
        }
    }
}
