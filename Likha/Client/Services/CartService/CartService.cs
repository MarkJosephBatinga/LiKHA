using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly HttpClient _http;

        public CartService(HttpClient http)
        {
            _http = http;
        }

        List<Cart> Carts = new List<Cart>();

        public async Task<List<Cart>> AddCart(Cart newCart)
        {
            var result = await _http.PostAsJsonAsync("api/cart", newCart);
            Carts = await result.Content.ReadFromJsonAsync<List<Cart>>();
            return Carts;
        }
    }
}
