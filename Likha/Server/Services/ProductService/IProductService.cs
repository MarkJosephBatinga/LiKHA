using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProductByCategory(string categoryUrl);
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);

        Task<List<Product>> AddProduct(Product newProduct);
    }
}
