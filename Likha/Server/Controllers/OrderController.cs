using Likha.Server.Services.OrderService;
using Likha.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Order>>> AddProduct(Order newOrder)
        {
            List<Order> Orders = await _orderService.AddProduct(newOrder);
            if (Orders != null)
                return Ok(Orders);
            return NotFound(Orders);
        }
    }
}
