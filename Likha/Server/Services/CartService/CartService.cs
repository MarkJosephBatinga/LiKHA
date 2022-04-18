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

        public async Task<List<Cart>> GetCartProducts(int userId)
        {
            return await _data.Carts.Where(p => p.UserId == userId).ToListAsync();
        }

        public async Task<List<Cart>> AddCart(Cart newCart)
        {
            await _data.Carts.AddAsync(newCart);
            await _data.SaveChangesAsync();
            Carts = await _data.Carts.ToListAsync();
            return Carts;
        }

        public async Task<List<Cart>> DeleteCart(Product product, int userId)
        {
            var cartProduct = await _data.Carts.Where(c => c.ProductId == product.Id && c.UserId == userId).FirstOrDefaultAsync();
            _data.Carts.Remove(cartProduct);
            await _data.SaveChangesAsync();
            var Carts = await _data.Carts.ToListAsync();
            return Carts;
        }
    }
}
