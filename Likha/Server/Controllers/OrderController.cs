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

        List<Order> Orders = new List<Order>();

        [HttpPost]
        public async Task<ActionResult<List<Order>>> AddProduct(Order newOrder)
        {
            Orders = await _orderService.AddProduct(newOrder);
            if (Orders != null)
                return Ok(Orders);
            return NotFound(Orders);
        }

        [HttpGet("buyer/{userId}")]
        public async Task<ActionResult<List<Order>>> GetOrderByBuyer(int userId)
        {
            Orders = await _orderService.GetOrderByBuyer(userId);
            if (Orders != null)
                return Ok(Orders);
            return NotFound(Orders);
        }

        [HttpGet("seller/{userId}")]
        public async Task<ActionResult<List<Order>>> GetOrderBySeller(int userId)
        {
            Orders = await _orderService.GetOrderBySeller(userId);
            if (Orders != null)
                return Ok(Orders);
            return NotFound(Orders);
        }

    }
}
