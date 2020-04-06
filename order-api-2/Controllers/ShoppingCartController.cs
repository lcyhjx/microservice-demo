using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace order_api.Controllers
{
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        // GET: api/Product
        [Route("api/shopping-carts")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine($"开始打印header信息");
            foreach (var item in this.Request.Headers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine($"打印header信息完成");
            return new string[] { "洗发水", "无人机" };
        }

        [Route("api/shopping-carts")]
        [HttpPost]
        public string Post()
        {
            return "添加商品到购物车成功";
        }


    }
}