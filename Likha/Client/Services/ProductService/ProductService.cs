using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public event Action OnChange;
        Product product = new Product();
        List<Product> AllProducts = new List<Product>();
        List<Product> ProductsbyCategory = new List<Product>();
        List<Product> ProductsbyArtist = new List<Product>();

        public async Task<List<Product>> AddProduct(Product newProduct)
        {
            var result = await _http.PostAsJsonAsync("api/Product", newProduct);
            var status = await result.Content.ReadFromJsonAsync<List<Product>>();
            return status;
        }

        public async Task<Product> LoadProduct(int id)
        {
            product = await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
            OnChange.Invoke();
            return product;
 
        }

        public async Task<List<Product>> LoadProducts()
        {
            AllProducts = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            OnChange.Invoke();
            return AllProducts;
        }

        public async Task<List<Product>> LoadProductsbyCategory(string categoryUrl)
        {
            ProductsbyCategory = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            OnChange.Invoke();
            return ProductsbyCategory;
        }

        public async Task<List<Product>> LoadProductsbyArtist(int artistId)
        {
            ProductsbyArtist = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Artist/{artistId}");
            OnChange.Invoke();
            return ProductsbyArtist;
        }

        public async Task<List<Product>> EditProduct(Product existingProduct)
        {
            var result = await _http.PutAsJsonAsync("api/Product", existingProduct);
            var Products = await result.Content.ReadFromJsonAsync<List<Product>>();
            return Products;
        }

        public async Task<List<Product>> DeleteProduct(Product existingProduct)
        {
            var result = await _http.PostAsJsonAsync<Product>($"api/Product/delete", existingProduct);
            var Products = await result.Content.ReadFromJsonAsync<List<Product>>();
            return Products;
        }
    }
}
