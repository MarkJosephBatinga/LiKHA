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

        [HttpGet("{UserId}")]
        public async Task<ActionResult<List<Cart>>> GetCartProducts(int UserId)
        {
            return Ok(await _cartService.GetCartProducts(UserId));
        }


        [HttpPost]
        public async Task<ActionResult<List<Cart>>> AddProduct(Cart newCart)
        {
            Carts = await _cartService.AddCart(newCart);
            if (Carts != null)
                return Ok(Carts);
            return NotFound(Carts);
        }

        [HttpPost("delete/{userId}")]
        public async Task<ActionResult<List<Cart>>> DeleteProduct(Product product, int userId)
        {
            Carts = await _cartService.DeleteCart(product, userId);
            if (Carts != null)
                return Ok(Carts);
            return NotFound(Carts);
        }
    }
}
