﻿using Likha.Server.Data;
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

        public async Task<List<Product>> AddProduct(Product newProduct)
        {
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
            List<Product> Products = await _context.Products.ToListAsync();
            return Products;
        }

        public async Task<List<Product>> GetProductByArtist(int ArtistId)
        {
            return await _context.Products.Where(p => p.ArtistId == ArtistId).ToListAsync();
        }

        public async Task<List<Product>> UpdateProduct(Product existingProduct)
        {
            List<Product> Products = await _context.Products.ToListAsync();
            var dbProduct = await _context.Products.FindAsync(existingProduct.Id);
            if (dbProduct != null)
            {
                _context.Entry(dbProduct).CurrentValues.SetValues(existingProduct);
                await _context.SaveChangesAsync();
            }
            return Products;
        }

        public async Task<List<Product>> DeleteProduct(Product existingProduct)
        {
            var dbCart = await _context.Carts.Where(c => c.ProductId == existingProduct.Id).ToListAsync();
            foreach (var item in dbCart)
            {
                _context.Carts.Remove(item);
            }

            var dborder = await _context.Orders.Where(o => o.ProductId == existingProduct.Id).ToListAsync();
            foreach (var item in dborder)
            {
                _context.Orders.Remove(item);
            }
            _context.Products.Remove(existingProduct);
            await _context.SaveChangesAsync();
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
