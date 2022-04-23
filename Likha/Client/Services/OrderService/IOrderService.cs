using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services.OrderService
{
    interface IOrderService
    {
        Task<List<Order>> DisplayBuyerOrder(int UserId);

        Task<List<Order>> AddOrder(Order newOrder);
    }
}
