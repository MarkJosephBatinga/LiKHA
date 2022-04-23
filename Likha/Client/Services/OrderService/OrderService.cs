using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;

        public OrderService(HttpClient http)
        {
            _http = http;
        }

        List<Order> Orders = new List<Order>();


        public async Task<List<Order>> AddOrder(Order newOrder)
        {
            var result = await _http.PostAsJsonAsync("api/Order", newOrder);
            var status = await result.Content.ReadFromJsonAsync<List<Order>>();
            return status;
        }

        public async Task<List<Order>> DisplayBuyerOrder(int UserId)
        {
            return Orders = await _http.GetFromJsonAsync<List<Order>>($"api/Order/{UserId}");
        }
    }
}
