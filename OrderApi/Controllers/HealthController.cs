using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace order_api.Controllers
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
