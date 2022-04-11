using Likha.Server.Data;
using Likha.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _data;

        public CartService(DataContext data)
        {
            _data = data;
        }

        List<Cart> Carts = new List<Cart>();

        public async Task<List<Cart>> AddCart(Cart newCart)
        {
            await _data.Carts.AddAsync(newCart);
            await _data.SaveChangesAsync();
            Carts = await _data.Carts.ToListAsync();
            return Carts;
        }
    }
}
