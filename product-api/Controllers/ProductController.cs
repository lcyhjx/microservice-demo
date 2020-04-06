using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace product_api.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/Product
        [Route("api/products")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "笔记本", "口罩" };
        }

    }
}
