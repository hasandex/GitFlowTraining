using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
            new { Id = 1, Name = "Laptop", Price = 800 },
            new { Id = 2, Name = "Mouse", Price = 20 },
            new { Id = 3, Name = "Keyboard", Price = 50 }
        };

            return Ok(products);
        }
    }
}
