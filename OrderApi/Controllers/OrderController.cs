using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace order_api.Controllers
{

    [ApiController]
    public class OrderController : ControllerBase
    {
        private ILogger _logger;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        // GET: api/Product
        [Route("api/orders")]
        [HttpGet]
        public  IEnumerable<string> Get()
        {

            //Task.Delay(3000).Wait();
            //Console.WriteLine("order api被调用了");
            return new string[] { "刘明的订单", "王天的订单" };
            //return new string[] { "帅的订单", "我的订单" };
            //throw new Exception("获取所有订单出错");
        }

        [Route("api/orders/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            string order = string.Empty;
            switch(id)
            {
                case 1:
                    order = "刘明的订单";
                    break;
                case 2:
                    order = "王天的订单";
                    break;
                default:
                    order = "没有找到订单";
                    break;
            }
            return order;
        
        }
    }
}