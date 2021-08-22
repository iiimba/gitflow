using Gitflow.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gitflow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
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
    }
}
