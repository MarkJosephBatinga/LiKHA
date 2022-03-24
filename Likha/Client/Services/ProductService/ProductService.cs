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

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Product> ProductsbyCategory { get; set; } = new List<Product>();

        public event Action OnChange;

        public async Task LoadProducts()
        {
            Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            OnChange.Invoke();
        }

        public async Task LoadProductsbyCategory(string categoryUrl)
        {
            ProductsbyCategory = await _http.GetFromJsonAsync<List<Product>>($"api/Product/{categoryUrl}");
            OnChange.Invoke();
        }
    }
}
