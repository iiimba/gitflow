using Gitflow.Models;
using Gitflow.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gitflow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product = new Product { Id = 1, Name = "Water", Price = 14.15m };

            return Ok(product);
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            var product1 = new Product { Id = 1, Name = "Water", Price = 14.15m };
            var product2 = new Product { Id = 2, Name = "Bread", Price = 11.5m };

            return Ok(new[] { product1, product2 });
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.SaveProduct(product);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);

            return Ok();
        }
    }
}
