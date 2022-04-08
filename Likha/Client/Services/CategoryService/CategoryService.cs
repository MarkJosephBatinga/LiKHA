using Likha.Client.Services;
using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Category>> LoadCategories()
        {
            List<Category> Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
            return Categories;
        }
    }
}
