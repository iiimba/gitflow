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
    }
}
