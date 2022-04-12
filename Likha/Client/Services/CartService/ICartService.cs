using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services.CartService
{
    interface ICartService
    {
        Task<List<Cart>> GetCartProducts(int userId);

        Task<List<Cart>> AddCart(Cart newCart);
    }
}
