﻿using Likha.Server.Services.CategoryService;
using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<Product>> GetProducts()
        {
            return Products;
        }

        public async Task<List<Product>> GetProductByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
            {
               new Product {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Monalisa",
                    Description = "The Famous Painting of Leonardo Da Vinci",
                    Artist = "Leonardo Da Vinci",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg/1200px-Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg",
                    Price = 29000000

                },
                new Product {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Spolarium",
                    Artist = "Juan Luna",
                    Description = "The Spoliarium is a painting by Filipino painter Juan Luna. Luna, working on canvas, spent eight months completing the painting which depicts dying gladiators.",
                    Image = "https://nolisoli.ph/wp-content/uploads/2018/08/IMG_3654.jpg",
                    Price = 3000000,
                },
                new Product {
                    Id = 3,
                    CategoryId = 3,
                    Title = "The Starry Night",
                    Artist = "Vincent van Gogh",
                    Description = "The Starry Night is an oil-on-canvas painting by the Dutch Post-Impressionist painter Vincent van Gogh. Painted in June 1889,",
                    Image = "https://www.vangoghgallery.com/img/starry_night_full.jpg",
                    Price = 4000000,
                },
                new Product {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Girl with a Pearl Earring",
                    Artist = "Vincent van Gogh",
                    Description = "Girl with a Pearl Earring is an oil painting by Dutch Golden Age painter Johannes Vermeer, dated c. 1665. ,",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/1665_Girl_with_a_Pearl_Earring.jpg/800px-1665_Girl_with_a_Pearl_Earring.jpg",
                    Price = 2000000,
                },
                new Product {
                    Id = 5,
                    CategoryId = 5,
                    Title = "Guernica",
                    Artist = "Pablo Picasso",
                    Description = "Guernica is a large 1937 oil painting on canvas by Spanish artist Pablo Picasso. It is one of his best-known works, regarded by many art critics as the most moving and powerful anti-war painting in history.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/7/74/PicassoGuernica.jpg",
                    Price = 20000000,
                }
            };
    }
}
