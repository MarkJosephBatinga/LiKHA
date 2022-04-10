using Likha.Server.Services.ProductService;
using Likha.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Likha.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(await _productService.GetProducts());
        }


        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }

        [HttpGet("Artist/{ArtistId}")]
        public async Task<ActionResult<List<Product>>> GetProductByArtist(int ArtistId)
        {
            return Ok(await _productService.GetProductByArtist(ArtistId));
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product newProduct)
        {
            List<Product> Products = await _productService.AddProduct(newProduct);
            if (Products != null)
                return Ok(Products);
            return NotFound(Products);
        }

        [HttpPut]
        public async Task<ActionResult<List<Product>>> UpdateProduct(Product existingProduct)
        {
            List<Product> Products = await _productService.UpdateProduct(existingProduct);
            if (Products != null)
                return Ok(Products);
            return NotFound(Products);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Product>>> DeleteAddress(Product existingProduct)
        {
            var Products = await _productService.DeleteProduct(existingProduct);
            if (Products == null)
                return NotFound(Products);
            return Ok(Products);
        }
    }
}
