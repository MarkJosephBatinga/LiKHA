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

        public List<Product> Products { get; set; }
        public List<Product> ProductsbyCategory { get; set; }

        Task LoadProducts();
        Task LoadProductsbyCategory(string categoryUrl);
        Task<Product> LoadProduct(int id);


        Task<List<Product>> AddProduct(Product newProduct);
    }
}
