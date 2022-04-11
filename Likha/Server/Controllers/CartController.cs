using Likha.Server.Services.CartService;
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
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        List<Cart> Carts = new List<Cart>();

        [HttpPost]
        public async Task<ActionResult<List<Cart>>> AddProduct(Cart newCart)
        {
            Carts = await _cartService.AddCart(newCart);
            if (Carts != null)
                return Ok(Carts);
            return NotFound(Carts);
        }
    }
}
