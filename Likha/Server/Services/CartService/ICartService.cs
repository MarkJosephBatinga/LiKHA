using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.CartService
{
    public interface ICartService
    {
        Task<List<Cart>> AddCart(Cart newCart);
    }
}
