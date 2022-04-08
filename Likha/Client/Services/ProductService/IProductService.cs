using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services
{
    interface IProductService
    {
        event Action OnChange;

        Task<List<Product>> LoadProducts();
        Task<List<Product>> LoadProductsbyCategory(string categoryUrl);
        Task<Product> LoadProduct(int id);


        Task<List<Product>> AddProduct(Product newProduct);
    }
}
