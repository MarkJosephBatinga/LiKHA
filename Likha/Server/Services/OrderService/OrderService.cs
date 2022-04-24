using Likha.Server.Data;
using Likha.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _data;

        public OrderService(DataContext data)
        {
            _data = data;
        }

        List<Order> Orders = new List<Order>();

        public async Task<List<Order>> AddProduct(Order newOrder)
        {
            await _data.Orders.AddAsync(newOrder);
            await _data.SaveChangesAsync();
            List<Order> Orders = await _data.Orders.ToListAsync();
            return Orders;
        }

        public async Task<List<Order>> GetOrderByBuyer(int UserId)
        {
            return Orders = await _data.Orders.Where(o => o.UserId == UserId).ToListAsync();
        }

        public async Task<List<Order>> GetOrderBySeller(int SellerId)
        {
            var SellerProduct = await _data.Products.Where(p => p.ArtistId == SellerId).ToListAsync();
            foreach(var product in SellerProduct)
            {
                var ProductOrders = await _data.Orders.Where(o => o.ProductId == product.Id).ToListAsync();
                foreach (var order in ProductOrders)
                {
                    Orders.Add(order);
                }
            }
            return Orders;
        }
    }
}
