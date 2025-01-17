﻿using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrderByBuyer(int UserId);
        Task<List<Order>> GetOrderBySeller(int SellerId);

        Task<List<Order>> AddProduct(Order newOrder);
    }
}
