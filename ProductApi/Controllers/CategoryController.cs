using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace product_api.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/Product
        [Route("api/categories")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "电子产品", "医护用品" };
        }
    }
}