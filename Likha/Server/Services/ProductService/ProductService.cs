using Likha.Server.Data;
using Likha.Server.Services.CategoryService;
using Likha.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductByCategory(string categoryUrl)
        {
            Category category = new Category();
            category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = new Product();
            product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }
    }
}
