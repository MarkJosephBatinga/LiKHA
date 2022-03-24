using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category> {
                new Category{ Id = 1, Name = "Paintings", Url = "paintings" },
                new Category{ Id = 2, Name = "Drawings", Url = "drawings" },
                new Category{ Id = 3, Name = "Digital Arts", Url = "digital_arts" },
                new Category{ Id = 4, Name = "Sculptures", Url = "sculptures" },
                new Category{ Id = 5, Name = "Ceramics", Url = "ceramics" },
                new Category{ Id = 6, Name = "Photography", Url = "photography" },
                new Category{ Id = 7, Name = "Designs", Url = "designs" },
                new Category{ Id = 8, Name = "Crafts", Url = "crafts" }
            };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
